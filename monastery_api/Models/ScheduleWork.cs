using System;
using System.Collections.Generic;

#nullable disable

namespace monastery_api.Models
{
    public partial class ScheduleWork
    {
        public int Id { get; set; }
        public int IdService { get; set; }
        public DateTime ScheduleWorkDate { get; set; }

       
    }
}
