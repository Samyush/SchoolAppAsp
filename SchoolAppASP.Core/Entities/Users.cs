using Newtonsoft.Json;
using SchoolAppASP.Infastructure.Models;
using System;
using System.Collections.Generic;

namespace SchoolAppASP.Core
{
    public class UsersDB
    {
        public IEnumerable<object> UserDatas()
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
            return new object[] { users };
        }
    }
}