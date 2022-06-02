using System.ComponentModel.DataAnnotations;

namespace Razor_Basic.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1,100,ErrorMessage = "Different number between 1 - 100"),Display(Name="Display Order")]
        public int DisplayOrder { get; set; } 

    }
}
