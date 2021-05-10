using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Persistance
{
    public class Author
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(64, MinimumLength = 2, ErrorMessage = "Last Name should be minimum 2 characters and a maximum of 64 characters")]
        public string FullName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}

