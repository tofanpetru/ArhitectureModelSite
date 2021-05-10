using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Persistance
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        [StringLength(300)]
        public string ImagePath { get; set; }
        public virtual User Owner { get; set; }
        public virtual Language Language { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public virtual Author Author { get; set; }
    }
}
