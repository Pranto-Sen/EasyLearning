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
    public class CourseController : ApiController
    {
        [HttpGet]
        [Route("api/Course/all")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = CourseService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

       

        [HttpGet]
        [Route("api/Course/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = CourseService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpGet]
        [Route("api/Course/{id}/Teacher")]
        public HttpResponseMessage GetCourseWithTeacher(int id)
        {
            try
            {
                var data = CourseService.GetCourseWithTeacher(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpGet]
        [Route("api/Course/{id}/Assignment")]
        public HttpResponseMessage GetwithCourseAssignment(int id)
        {
            try
            {
                var data = CourseService.GetwithCourseAssignment(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpPost]
        [Route("api/Course/create")]
        public HttpResponseMessage Add(CourseDTO course)
        {
            try
            {
                var data = CourseService.Add(course);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpPost]
        [Route("api/Course/update")]
        public HttpResponseMessage Update(CourseDTO course)
        {
            try
            {
                var res = CourseService.Update(course);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/Course/delete/{id:int}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var res = CourseService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.InnerException.InnerException.Message);
            }

        }

    }
}

