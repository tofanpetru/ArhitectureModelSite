using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Persistance
{
    public class Genre
    {
        public int Id { get; set; }
        [StringLength(32)]
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<PendingBook> PendingBooks { get; set; }
    }
}
