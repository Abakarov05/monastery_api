using System;
using System.Collections.Generic;

#nullable disable

namespace monastery_api.Models
{
    public partial class Task
    {
        public Task()
        {
        }

        public int Id { get; set; }
        public string TaskName { get; set; }
        public int IdTypeTask { get; set; }

      
    }
}
