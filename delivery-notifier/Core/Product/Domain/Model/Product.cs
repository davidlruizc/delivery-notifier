using Utilities.Domain;

namespace Core.Product.Domain.Model
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

        private Product(Guid id, string name, string image, decimal price)
        {
            Id = id;
            Name = name;
            Image = image;
            Price = price;
        }

        internal void Initialize()
        {
            InitializeBase();
        }

        public static Product Of(Guid id, string name, string image, decimal price)
        {
            return new Product(id, name, image, price);
        }
    }
}
