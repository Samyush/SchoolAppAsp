using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SchoolAppASP.Core;
using SchoolAppASP.Core.Entities;
using SchoolAppASP.Infastructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolAppAsp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IMediator _mediator;
       
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<SchoolAppASP.Core.Entities.UsersDB>> Get()
        {
            return await _mediator.Send(new GetAllUserQuery());
        }
        //[HttpPost]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public async Task<ActionResult<UserResponse>> CreateEmployee([FromBody] CreateUsersCommand command)
        //{
        //    var result = await _mediator.Send(command);
        //    return Ok(result);
        //}

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
            UsersDB users = new UsersDB();
            users.UserId = 12;
            users.FirstName = "hello";
            users.Email = "hello123";
            users.DateOfBirth = DateTime.UtcNow;

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
            UsersDB users = new UsersDB();
            users.UserId = 12;
            users.FirstName = "hello";
            users.Email = "hello123";
            users.DateOfBirth = DateTime.UtcNow;

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
            UsersDB users = new UsersDB();
            users.UserId = 12;
            users.FirstName = "hello";
            users.Email = "hello123";
            users.DateOfBirth = DateTime.UtcNow;

            var jsonRt = JsonConvert.SerializeObject(users);

            return jsonRt;
        }


        /// <summary>
        /// the object can be directly send through IActionResult and directly inside Ok(object)
        /// and here the data has been shared from code -> Entity -> UserDB class where IEnumerable is used 
        /// </summary>
        /// <returns></returns>
      


        [HttpGet]
        [Route("test123")]
        public string Test()
        {
            UsersDB csvt = new UsersDB();
            return csvt.ToString();
        }

    }

    internal class GetAllUserQuery : IRequest<List<UsersDB>>
    {
    }
}
