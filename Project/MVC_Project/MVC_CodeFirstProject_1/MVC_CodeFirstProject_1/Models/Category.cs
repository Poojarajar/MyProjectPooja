namespace MVC_CodeFirstProject_1.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<ProductModel> Products { get; set; }

    }
}
