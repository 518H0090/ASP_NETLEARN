using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_FULL.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]

        [Range(1,100,ErrorMessage = "Display Order must between 1 and 100")]
        public int DisplayOrder { get; set; }
        public string City { set; get; }
        public string Hobby { set; get; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
