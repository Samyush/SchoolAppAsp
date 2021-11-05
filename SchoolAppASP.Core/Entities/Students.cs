using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolAppASP.Core.Entities
{
    public class Students
    {
        [Key]
        public Int64 ID { get; set; }
        public Int64 User_ID { get; set; }
        public string Grade { get; set; }

        [ForeignKey("User_ID")]
        public UsersDB UserID { get; set; }
    }
}
