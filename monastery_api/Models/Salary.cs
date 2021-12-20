using System;
using System.Collections.Generic;

#nullable disable

namespace monastery_api.Models
{
    public partial class Salary
    {
        public int Id { get; set; }
        public int SalaryPrice { get; set; }
        public int IdUser { get; set; }

       
    }
}
