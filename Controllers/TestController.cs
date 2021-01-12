using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace IT_Career_Counseling.Controllers
{
    public class TestController : ApiController
    {
        [Route("")]
        public IHttpActionResult GetContent()
        {
            string req_txt;
            using (StreamReader reader = new StreamReader(HttpContext.Current.Request.InputStream))
            {
                req_txt = reader.ReadToEnd();
            }

            return Ok(req_txt);
        }
    }
}
