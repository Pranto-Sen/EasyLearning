using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace BLL.Services
{
    public class CourseService
    {
        public static bool Add(CourseDTO Course)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CourseDTO, Course>();
            });
            var mapper = new Mapper(config);
            var date = mapper.Map<Course>(Course);
            
            return DataAccessFactory.CourseData().Create(date);
        }

        public static List<CourseDTO> Get()
        {
            var data = DataAccessFactory.CourseData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Course, CourseDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<CourseDTO>>(data);
        }

        public static CourseDTO Get(int id)
        {
            var data = DataAccessFactory.CourseData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Course, CourseDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CourseDTO>(data);
            return mapped;

        }

        public static CourseTeacherDTO GetCourseWithTeacher(int id)
        {
            var data = DataAccessFactory.CourseData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Teacher, TeacherDTO>();
                c.CreateMap<Course, CourseTeacherDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CourseTeacherDTO>(data);
            return mapped;

        }

        public static CourseAssignmentDTO GetwithCourseAssignment(int id)
        {
            var data = DataAccessFactory.CourseData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Course, CourseAssignmentDTO>();
                c.CreateMap<Assignment, AssignmentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CourseAssignmentDTO>(data);
            return mapped;

        }


        public static bool Update(CourseDTO t)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CourseDTO, Course>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Course>(t);

            return DataAccessFactory.CourseData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.CourseData().Delete(id);
        }
    }
}

