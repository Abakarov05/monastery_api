using System;
using System.Collections.Generic;

#nullable disable

namespace monastery_api.Models
{
    public partial class Discount
    {
        public Discount()
        {
         
        }

        public int Id { get; set; }
        public int DiscountPercent { get; set; }
    }
}
