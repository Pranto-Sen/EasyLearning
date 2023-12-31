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
    public class CommunityService
    {
        public static bool Add(CommunityDTO community)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CommunityDTO, Community>();
            });
            var mapper = new Mapper(config);
            var date = mapper.Map<Community>(community);
            return DataAccessFactory.CommunityData().Create(date);
        }

        public static List<CommunityDTO> Get()
        {
            var data = DataAccessFactory.CommunityData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Community, CommunityDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<CommunityDTO>>(data);
        }

        public static CommunityDTO Get(int id)
        {
            var data = DataAccessFactory.CommunityData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Community, CommunityDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CommunityDTO>(data);
            return mapped;

        }

        public static bool Update(CommunityDTO Community)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CommunityDTO, Community>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Community>(Community);

            return DataAccessFactory.CommunityData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.CommunityData().Delete(id);
        }

    }
}
