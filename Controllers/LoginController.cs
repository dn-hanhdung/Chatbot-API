using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace IT_Career_Counseling.Controllers
{
    [RoutePrefix("login")]
    public class LoginController : ApiController
    {
        [Route("")]
        [HttpGet]
        [ActionName("Login")]
        public HttpResponseMessage Index()
        {
            var path = "login.html";
            var response = new HttpResponseMessage();
            response.Content = new StringContent(File.ReadAllText(path));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }
    }
}
