using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EasyLearning.Controllers
{
    public class EnrollController : ApiController
    {
        [HttpPost]
        [Route("api/Enroll")]
        public HttpResponseMessage Add(EnrollDTO c)
        {
            try
            {
                var data = EnrollService.Add(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpGet]
        [Route("api/Enroll/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = EnrollService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }  
        
        [HttpGet]
        [Route("api/Enrollinfo/{date}")]
        public HttpResponseMessage Getinfo(DateTime date)
        {
            try
            {
                var data = EnrollService.Getinfo(date);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }




    }
}
