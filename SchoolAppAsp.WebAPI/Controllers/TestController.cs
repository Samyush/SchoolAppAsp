using Microsoft.AspNetCore.Mvc;
using SchoolAppASP.Infastructure;
using SchoolAppASP.Infastructure.Models;
using System;
using System.Threading.Tasks;

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

        [HttpGet]
        [Route("123")]
        public IActionResult TryOn()
        {
            //return Unauthorized();
            //return NotFound();
            return BadRequest();
        }

        /// <summary>
        /// the below code even though not having any errors now
        /// it shows run time errors as path or route on RedirectToAction
        /// </summary>
        /// <returns>to find out the solution or working mech of RedirectToAction</returns>
        [HttpGet]
        [Route("sam")]
        public async Task<IActionResult> Adds()
        {
            Users users = new Users();
            users.ID = 12;
            users.Name = "hello";
            users.Email = "hello123";
            users.expDt = DateTime.UtcNow;

            try
            {
                //RedirectToAction
                await Task.Run(() =>
                {
                    for (int a = 0; a < 2; a++)
                    {
                        Console.WriteLine(" Simple demonstration of await keyword.");
                    }
                });
                return RedirectToAction("~/api/Users/UserDetails");

            }
            catch (Exception)
            {
                return Unauthorized();
            }
        }
    }
}
