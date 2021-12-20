using System;
using System.Collections.Generic;

#nullable disable

namespace monastery_api.Models
{
    public partial class Budget
    {
        public int Id { get; set; }
        public int IdNotePrice { get; set; }
        public int IdOfferItemPrice { get; set; }
        public DateTime BudgetDate { get; set; }
    }
}
