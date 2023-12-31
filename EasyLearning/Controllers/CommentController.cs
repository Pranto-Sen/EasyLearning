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
    public class CommentController : ApiController
    {
        [HttpPost]
        [Route("api/Comment/create")]
        public HttpResponseMessage Add(CommentDTO Comment)
        {
            try
            {
                var data = CommentService.Add(Comment);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }


        [HttpGet]
        [Route("api/Comment/all")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = CommentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
        [HttpGet]
        [Route("api/Comment/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = CommentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpPost]
        [Route("api/Comment/update")]
        public HttpResponseMessage Update(CommentDTO Comment)
        {
            try
            {
                var res = CommentService.Update(Comment);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/Comment/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var res = CommentService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

    }
}
