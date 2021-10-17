using Newtonsoft.Json;
using SchoolAppASP.Infastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolAppASP.Core
{
    public class UsersDB
    {

        //here are the models for DB to be created for user attribute

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public IEnumerable<object> UserDatas()
        {
            UserId users = new UserId();
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