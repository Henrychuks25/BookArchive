using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookArchive.Models
{
    public partial class Students
    {
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }
        public int? Point { get; set; }
    }
}
