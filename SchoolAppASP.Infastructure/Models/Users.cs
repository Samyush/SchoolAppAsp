using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolAppASP.Infastructure.Models
{
    public class Users
    {

        //var assadf = 23;

        [Key]
        public long ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime expDt { get; set; }

    }
}
