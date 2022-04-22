using System.ComponentModel.DataAnnotations;

namespace DioApi.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength (60)]
        [MinLength(3)]
        public string Name { get; set; }
    }
}
