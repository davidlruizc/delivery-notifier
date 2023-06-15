using Utilities.Domain;

namespace Core.Product.Domain.Model
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

       
    }
}
