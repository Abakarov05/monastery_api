using System;
using System.Collections.Generic;

#nullable disable

namespace monastery_api.Models
{
    public partial class Offer
    {
        public Offer()
        {
           
        }

        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdItem { get; set; }
        public int IdOfferStatus { get; set; }
        public DateTime OfferDate { get; set; }

      
    }
}
