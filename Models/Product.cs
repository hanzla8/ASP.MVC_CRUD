using System.ComponentModel.DataAnnotations;

namespace ProductCrud_CodeWithPushpa.Models
{
    public class Product
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string? Description { get; set; }
        public string? Image { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}
