using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BasicAuthDemo.Controllers
{
    [Authorize]
    public class DemoDataController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(new { demoData = "You have to be authenticated to access this!" });
        }
    }
}
