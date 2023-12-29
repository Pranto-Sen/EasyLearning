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
    public class TeacherController : ApiController
    {
        [HttpGet]
        [Route("api/Teacher/all")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = TeacherService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpGet]
        [Route("api/Teacher/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = TeacherService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpGet]
        [Route("api/Teacher/{id}/Course")]
        public HttpResponseMessage GetwithCourse(int id)
        {
            try
            {
                var data = TeacherService.GetwithCourse(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpGet]
        [Route("api/Teacher/{id}/CoursewithAssignment")]
        public HttpResponseMessage GetwithCourseAssign(int id)
        {
            try
            {
                var data = TeacherService.GetwithCourseAssign(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpPost]
        [Route("api/Teacher/register")]
        public HttpResponseMessage register(TeacherDTO t)
        {
            try
            {
                var data = TeacherService.Register(t);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpPost]
        [Route("api/Teacher/update")]
        public HttpResponseMessage Update(TeacherDTO t)
        {
            try
            {
                var res = TeacherService.Update(t);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/Teacher/delete/{id:int}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var res = TeacherService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.InnerException.InnerException.Message);
            }

        }
    }
}
