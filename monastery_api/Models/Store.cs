using System;
using System.Collections.Generic;

#nullable disable

namespace monastery_api.Models
{
    public partial class Store
    {
        public Store()
        {
           
        }

        public int Id { get; set; }
        public string StoreItemName { get; set; }
        public int StoreItemAvailable { get; set; }

       
    }
}
