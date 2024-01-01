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
    public class PostService
    {
        public static bool Add(PostDTO Post)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PostDTO, Post>();
            });
            var mapper = new Mapper(config);
            var date = mapper.Map<Post>(Post);
            return DataAccessFactory.PostData().Create(date);
        }

        public static List<PostDTO> Get()
        {
            var data = DataAccessFactory.PostData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Post, PostDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<PostDTO>>(data);
        }

        public static PostDTO Get(int id)
        {
            var data = DataAccessFactory.PostData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Post, PostDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PostDTO>(data);
            return mapped;

        }
        
        public static PostComentDTO GetPostWithComment(int id)
        {
            var data = DataAccessFactory.PostData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Post, PostComentDTO>();
                c.CreateMap<Comment, CommentDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PostComentDTO>(data);
            return mapped;

        }

        public static bool Update(PostDTO Post)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PostDTO, Post>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Post>(Post);

            return DataAccessFactory.PostData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.PostData().Delete(id);
        }
    }
}
