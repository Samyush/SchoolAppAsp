using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolAppASP.Infastructure;

namespace SchoolAppAsp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("test123")]
        public string Test()
        {
            Class1 csvt = new Class1();
            return csvt.Returns();
        }

        [HttpGet]
        [Route("jsonTry")]
        public IActionResult TryArray()
        {

            var listDt = new int[3, 4] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 }, };
            var tester = "success in JSON";

            //var jpt = 1;
            //var value = JSON.stringify({
            //prop1: 'value 1',
            //prop2: 'value 2'
            //});


            //how to send array or json out of asp.net core api -> Ok(object) sends data as JSON
            return Ok(tester);
        }
    }
}
