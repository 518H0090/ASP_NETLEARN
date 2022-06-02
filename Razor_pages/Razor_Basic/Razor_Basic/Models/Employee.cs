using System.ComponentModel.DataAnnotations;

namespace Razor_Basic.Models
{
	public class Employee
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Address { get; set; }
		public long phoneNumber { get; set; }
		[Range(1,200,ErrorMessage ="OverCome Range")]
		public int DisplayOrder { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.Now;
	}
}
