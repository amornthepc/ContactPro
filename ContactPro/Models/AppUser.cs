using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactPro.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [DisplayName("First Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and a max {1}", MinimumLength = 2)]
        public string? FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and a max {1}", MinimumLength = 2)]
        public string? LastName { get; set; }

        [NotMapped]
        public string? FullName => $"{FirstName} {LastName}";

        // Navigation Properties
        public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();
        public virtual ICollection<Contact> Contacts { get; set; } = new HashSet<Contact>();
    }
}
