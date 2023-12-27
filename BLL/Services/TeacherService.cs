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
    public class TeacherService
    {
        public static bool Register(TeacherDTO t)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TeacherDTO, Teacher>();
            });
            var mapper = new Mapper(config);
            var date = mapper.Map<Teacher>(t);
            return DataAccessFactory.TeacherData().Create(date);
        }

        public static List<TeacherDTO> Get()
        {
            var data = DataAccessFactory.TeacherData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Teacher, TeacherDTO>();
            });
            var mapper = new Mapper(config);
           return mapper.Map<List<TeacherDTO>>(data);
        }

        public static TeacherDTO Get(int id)
        {
            var data = DataAccessFactory.TeacherData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Teacher, TeacherDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TeacherDTO>(data);
            return mapped;

        }

        public static bool Update(TeacherDTO t)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<TeacherDTO, Teacher>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Teacher>(t);

            return DataAccessFactory.TeacherData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.TeacherData().Delete(id);
        }
    }
}
