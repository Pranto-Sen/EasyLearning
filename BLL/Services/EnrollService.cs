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
    public class EnrollService
    {
        public static bool Add(EnrollDTO Enroll)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EnrollDTO,Enroll>();
            });
            var mapper = new Mapper(config);
            var date = mapper.Map<Enroll>(Enroll);
            return DataAccessFactory.EnrollData().Create(date);
        }

        public static EnrollDTO Get(int id)
        {
            var data = DataAccessFactory.EnrollData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Enroll, EnrollDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<EnrollDTO>(data);
            return mapped;

        }
    }
}
