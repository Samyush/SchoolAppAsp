using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SchoolAppASP.Core.Entities;

namespace SchoolAppASP.Infastructure
{
    public class Class1
    {
        public string Returns()
        {
            return "Tripti";
        }

        public IEnumerable<object> UserDatas()
        {
            UsersDB users = new UsersDB();
            users.UserId = 12;
            users.FirstName = "hello";
            users.LastName = "hello";
            users.Email = "hello123";
            users.DateOfBirth = DateTime.UtcNow;

            var jsonRt = JsonConvert.SerializeObject(users);

            // TODO: find the use of JsonConvert.SerializeObject()??????  

            //yield return jsonRt;

            //return new string[] { users };
            return new object[] { users };
        }
    }
}
