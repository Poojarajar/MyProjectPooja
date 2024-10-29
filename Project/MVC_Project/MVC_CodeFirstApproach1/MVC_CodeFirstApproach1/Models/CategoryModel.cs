using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MVC_CodeFirstApproach1.Models
{
    [Table("tblCategory")]

    public class CategoryModel
    {
        
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<ProductModel> Products { get; set; }

    }
}
