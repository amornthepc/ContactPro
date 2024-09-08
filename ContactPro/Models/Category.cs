using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactPro.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [ForeignKey("AppUser")]
        [Required]
        public string? AppUserId { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        public string? Name { get; set; }

        // Virtuals - Navigation property
        public virtual AppUser? AppUser { get; set; }
        public virtual ICollection<Contact>? Contacts { get; set; } = new HashSet<Contact>();
    }
}
