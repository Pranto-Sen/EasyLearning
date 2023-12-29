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
    public class AsignmentController : ApiController
    {
        [HttpPost]
        [Route("api/Assignment/create")]
        public HttpResponseMessage Add(AssignmentDTO Assignment)
        {
            try
            {
                var data = AssignmentService.Add(Assignment);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }


        [HttpGet]
        [Route("api/Assignment/all")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = AssignmentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
        [HttpGet]
        [Route("api/Assignment/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = AssignmentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpPost]
        [Route("api/Assignment/update")]
        public HttpResponseMessage Update(AssignmentDTO Assignment)
        {
            try
            {
                var res = AssignmentService.Update(Assignment);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/Assignment/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var res = AssignmentService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }


    }
}
