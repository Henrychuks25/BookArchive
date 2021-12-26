using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookArchive.Models
{
    public partial class Borrows
    {
        public Guid BorrowId { get; set; }
        public Guid? StudentId { get; set; }
        public Guid? BookId { get; set; }
        public DateTime? TakenDate { get; set; }
        public DateTime? BroughtDate { get; set; }
    }
}
