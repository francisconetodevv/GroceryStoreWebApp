using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryStoreWebApp.Models
{
    public class Product
    {
        // Primary key
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é preenchimento obrigatório.")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é preenchimento obrigatório.")]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required(ErrorMessage = "O campo {0} é preenchimento obrigatório.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "O campo {0} é preenchimento obrigatório.")]
        public int Quantity { get; set; }

    }
}
