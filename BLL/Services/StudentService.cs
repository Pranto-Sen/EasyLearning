using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {
        public static bool Add(StudentDTO Student)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(config);
            var date = mapper.Map<Student>(Student);
            return DataAccessFactory.StudentData().Create(date);
        }

        public static List<StudentDTO> Get()
        {
            var data = DataAccessFactory.StudentData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<StudentDTO>>(data);
        }

        public static List<StudentCourseDTO> GetwithCourse(int id)
        {
            var data = DataAccessFactory.StudentData().GetCourse(id);
            var cfg = new MapperConfiguration(c =>
            {
                //
                c.CreateMap<StudentCourse, StudentCourseDTO>();
                c.CreateMap<Student, StudentDTO>();
                c.CreateMap<Course, CourseDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<StudentCourseDTO>>(data);
          
            return mapped;

        }

        public static List<AssignmentDTO> GetwithCourseAssignment(int id)
        {
            var data = DataAccessFactory.StudentData().GetCoursewithAssignment(id);
            var cfg = new MapperConfiguration(c =>
            {
                //
                //c.CreateMap<StudentCourse, StudentCourseAssignmentDTO>();
                //c.CreateMap<Student, StudentDTO>();
                //c.CreateMap<Course, CourseDTO>();
                c.CreateMap<Assignment, AssignmentDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AssignmentDTO>>(data);

            return mapped;

        }

        public static StudentPostDTO GetwithPost(int id)
        {
            var data = DataAccessFactory.PostData().GetStudentWithPost(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Student, StudentPostDTO>();
                c.CreateMap<Post, PostDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<StudentPostDTO>(data);

            return mapped;

        } 
        
        public static StudentPostWithCommentDTO GetwithPostComment(int id)
        {
            var data = DataAccessFactory.PostData().GetStudentWithPost(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Student, StudentPostWithCommentDTO>();
                c.CreateMap<Post, PostComentDTO>();
                c.CreateMap<Comment, CommentDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<StudentPostWithCommentDTO>(data);

            return mapped;

        }

        public static StudentDTO Get(int id)
        {
            var data = DataAccessFactory.StudentData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<StudentDTO>(data);
            return mapped;

        }

        public static bool Update(StudentDTO Student)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Student>(Student);

            return DataAccessFactory.StudentData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.StudentData().Delete(id);
        }
    }
}
