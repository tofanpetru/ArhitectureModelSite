using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Persistance
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(64, MinimumLength = 1, ErrorMessage = "Last Name should be minimum 1 characters and a maximum of 64 characters")]
        [MinLength(3)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(64, MinimumLength = 1, ErrorMessage = "Last Name should be minimum 1 characters and a maximum of 64 characters")]
        [MinLength(3)]
        public string LastName { get; set; }
        public string ProfileImage { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<PendingBook> PendingBooks { get; set; }
    }
}
