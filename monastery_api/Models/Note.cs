using System;
using System.Collections.Generic;

#nullable disable

namespace monastery_api.Models
{
    public partial class Note
    {
        public Note()
        {
           
        }

        public int Id { get; set; }
        public int IdUser { get; set; }
        public int NotePrice { get; set; }

       
    }
}
