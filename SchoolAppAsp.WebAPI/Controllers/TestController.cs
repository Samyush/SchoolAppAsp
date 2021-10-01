using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolAppASP.Infastructure;
using SchoolAppASP.Core;

namespace SchoolAppAsp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("test1")]
        public string Test()
        {

            Class1 csvt = new Class1();
            return csvt.Returns();
        }


        [HttpGet]
        [Route("test2")]
        public string Testorate()
        {
            Tester ts = new Tester();
            return ts.Testers();
        }
    }
}
