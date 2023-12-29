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
    public class AssignmentService
    {
        public static bool Add(AssignmentDTO Assignment)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AssignmentDTO,Assignment>();
            });
            var mapper = new Mapper(config);
            var date = mapper.Map<Assignment>(Assignment);
            return DataAccessFactory.AssignmentData().Create(date);
        }

        public static List<AssignmentDTO> Get()
        {
            var data = DataAccessFactory.AssignmentData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Assignment, AssignmentDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<AssignmentDTO>>(data);
        }

        public static AssignmentDTO Get(int id)
        {
            var data = DataAccessFactory.AssignmentData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Assignment, AssignmentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AssignmentDTO>(data);
            return mapped;

        }

        public static bool Update(AssignmentDTO Assignment)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AssignmentDTO, Assignment>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Assignment>(Assignment);

            return DataAccessFactory.AssignmentData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.AssignmentData().Delete(id);
        }
    }
}
