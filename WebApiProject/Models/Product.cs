using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiProject.Models
{
    [Table("Product")]
    public class Product
    {

        [Key]  
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int price { get; set; }
       
        
    }
}
