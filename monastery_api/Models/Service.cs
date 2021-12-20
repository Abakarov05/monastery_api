using System;
using System.Collections.Generic;

#nullable disable

namespace monastery_api.Models
{
    public partial class Service
    {
        public Service()
        {
            
        }

        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }

        
    }
}
