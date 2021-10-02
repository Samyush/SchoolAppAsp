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

        public string Test()
        {

            Class1 csvt = new Class1();
            return "Test Success";
        }









    }
}
