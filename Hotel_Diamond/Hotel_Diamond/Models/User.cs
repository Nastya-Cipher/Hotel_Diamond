using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Diamond.Models
{
    public class User
    {
        public int IDUser { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Block { get; set; }
        public DateTime TimeBlock { get; set; }
    }
}