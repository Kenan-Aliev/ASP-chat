using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_chat.Models
{
    public class User
    {
        public int User_ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Connection_Id { get; set; }

        public bool? IsOnline { get; set; }
    }
}