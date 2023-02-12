using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class User
    {
        public long Id { get; set; }  
        public string UserName { get; set; } 
        public string Password { get; set; }
        public string Email { get; set; }
    }
}