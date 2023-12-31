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
    public class CommentService
    {
        public static bool Add(CommentDTO Comment)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CommentDTO,Comment>();
            });
            var mapper = new Mapper(config);
            var date = mapper.Map<Comment>(Comment);
            return DataAccessFactory.CommentData().Create(date);
        }

        public static List<CommentDTO> Get()
        {
            var data = DataAccessFactory.CommentData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Comment, CommentDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<CommentDTO>>(data);
        }

        public static CommentDTO Get(int id)
        {
            var data = DataAccessFactory.CommentData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Comment, CommentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CommentDTO>(data);
            return mapped;

        }

        public static bool Update(CommentDTO Comment)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CommentDTO, Comment>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Comment>(Comment);

            return DataAccessFactory.CommentData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.CommentData().Delete(id);
        }
    }
}
