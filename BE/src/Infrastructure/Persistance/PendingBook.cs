using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Infrastructure.Persistance
{
    public class PendingBook
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        [StringLength(300)]
        public string ImagePath { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(64, MinimumLength = 2, ErrorMessage = "Last Name should be minimum 2 characters and a maximum of 64 characters")]
        public string AuthorFullName { get; set; }
        public virtual User Owner { get; set; }
        public virtual Language Language { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
    }
}