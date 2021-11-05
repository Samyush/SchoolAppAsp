using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolAppASP.Core.Entities
{
    public class Teachers
    {
        public Int64 ID { get; set; }
        public string Faculty { get; set; }

        [ForeignKey("User_ID")]
        public UsersDB UserID { get; set; }
    }
}
