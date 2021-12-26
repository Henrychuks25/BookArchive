using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookArchive.Models
{
    public partial class Books
    {
        public Guid BookId { get; set; }
        public string Name { get; set; }
        public int? Pagecount { get; set; }
        public int? Point { get; set; }
        public Guid? AuthorId { get; set; }
        public Guid? TypeId { get; set; }
    }
}
