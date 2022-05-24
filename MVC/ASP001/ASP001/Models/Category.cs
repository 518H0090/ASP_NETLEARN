using System.ComponentModel.DataAnnotations;

namespace ASP001.Models
{
    public class Category
    {
        //Dùng attribute Key để thông báo khóa chính
        [Key]
        public int Id { get; set; }
        //giá trị không được để trống
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
