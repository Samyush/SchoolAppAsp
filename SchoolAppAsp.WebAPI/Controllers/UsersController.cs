using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SchoolAppASP.Infastructure.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolAppAsp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        [HttpPost]
        [Route("Login")]
        public string Login(string name, string password)
        {
            if(name == "name" && password == "name")
            {
                return "success";
            }
            else
            {
                return "failed";
            }
        }

        [HttpPost]
        [Route("Logout")]
        public string Logout()
        {
            return "success";
        }

        // how to send data as json here on return
        [HttpGet]
        [Route("UserDetails")]
        public IEnumerable<String> UserData()
        {
            Users users = new Users();
            users.ID = 12;
            users.Name = "hello";
            users.Email = "hello123";
            users.expDt = DateTime.UtcNow;

            var jsonRt = JsonConvert.SerializeObject(users);

            //yield return jsonRt;

            //return new string[] { users };
            return new string[] { jsonRt };
        }

        [HttpGet]
        [Route("UserDetails2")]
        public string UserData2()
        {
            Users users = new Users();
            users.ID = 12;
            users.Name = "hello";
            users.Email = "hello123";
            users.expDt = DateTime.UtcNow;

            var jsonRt = JsonConvert.SerializeObject(users);

            return jsonRt;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        [HttpGet]
        [Route("test123")]
        public string Test()
        {
            Users csvt = new Users();
            return csvt.ToString();
        }
    }
}
