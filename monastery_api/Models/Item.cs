using System;
using System.Collections.Generic;

#nullable disable

namespace monastery_api.Models
{
    public partial class Item
    {
        public Item()
        {
          
        }

        public int Id { get; set; }
        public int IdStore { get; set; }
        public int IdType { get; set; }
        public int ItemPrice { get; set; }

      
    }
}
