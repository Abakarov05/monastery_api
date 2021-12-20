using System;
using System.Collections.Generic;

#nullable disable

namespace monastery_api.Models
{
    public partial class Todo
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdTask { get; set; }
        public string TodoStatus { get; set; }

      
    }
}
