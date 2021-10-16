using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SchoolAppASP.Core;
using SchoolAppASP.Infastructure.Models;
using System;
using System.Collections.Generic;

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
            if (name == "name" && password == "name")
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

        /// <summary>
        /// the object can be directly send through IActionResult and directly inside object type declaration
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("UserDetails")]
        public IEnumerable<object> UserData()
        {
            Users users = new Users();
            users.ID = 12;
            users.Name = "hello";
            users.Email = "hello123";
            users.expDt = DateTime.UtcNow;

            var jsonRt = JsonConvert.SerializeObject(users);

            //yield return jsonRt;

            //return new string[] { users };
            return new object[] { users };
        }

        /// <summary>
        /// here in below code the string returns all data of user object
        /// as string and inside JSON convert serilize object
        /// </summary>
        /// <returns>errors comes along when multiple controller methods have same routes</returns>
        [HttpGet]
        [Route("UserDetailsString")]
        public IEnumerable<string> UserDatas()
        {
            Users users = new Users();
            users.ID = 12;
            users.Name = "hello";
            users.Email = "hello123";
            users.expDt = DateTime.UtcNow;

            var jsonRt = JsonConvert.SerializeObject(users);

            // TODO: find the use of JsonConvert.SerializeObject()??????  

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


        /// <summary>
        /// the object can be directly send through IActionResult and directly inside Ok(object)
        /// and here the data has been shared from code -> Entity -> UserDB class where IEnumerable is used 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("test22")]
        public IActionResult Noname()
        {
            UsersDB udb = new UsersDB();

            return Ok(udb.UserDatas());
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
