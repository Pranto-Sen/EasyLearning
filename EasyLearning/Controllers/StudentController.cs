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
    public class StudentController : ApiController
    {
        [HttpPost]
        [Route("api/Student/register")]
        public HttpResponseMessage Add(StudentDTO Student)
        {
            try
            {
                var data = StudentService.Add(Student);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }


        [HttpGet]
        [Route("api/Student/all")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = StudentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
        [HttpGet]
        [Route("api/Student/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = StudentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpGet]
        [Route("api/Student/{id}/Course")]
        public HttpResponseMessage GetwithCourse(int id)
        {
            try
            {
                var data = StudentService.GetwithCourse(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpGet]
        [Route("api/Student/{id}/Assignment")]
        public HttpResponseMessage GetwithCourseAssignment(int id)
        {
            try
            {
                var data = StudentService.GetwithCourseAssignment(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpGet]
        [Route("api/Student/{id}/Post")]
        public HttpResponseMessage GetwithPost(int id)
        {
            try
            {
                var data = StudentService.GetwithPost(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpGet]
        [Route("api/Student/{id}/PostWithComment")]
        public HttpResponseMessage GetwithPostComment(int id)
        {
            try
            {
                var data = StudentService.GetwithPostComment(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpPost]
        [Route("api/Student/update")]
        public HttpResponseMessage Update(StudentDTO Student)
        {
            try
            {
                var res = StudentService.Update(Student);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/Student/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var res = StudentService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

    }
}
