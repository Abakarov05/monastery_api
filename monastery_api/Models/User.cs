using System;
using System.Collections.Generic;

#nullable disable

namespace monastery_api.Models
{
    public partial class User
    {
        public User()
        {
          
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public int IdRole { get; set; }
        public int IdDiscount { get; set; }

       
    }
}
