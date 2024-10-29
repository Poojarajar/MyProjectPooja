using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MVC_CodeFirstApproach1.Models
{
    [Table("tblProduct")]

    public class ProductModel
    {

        [Key]

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }

    }
}
