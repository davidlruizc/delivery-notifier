using Utilities.Domain;

namespace Core.Restaurant.Domain.Model
{
    public class Restaurant : BaseEntity
    {
        public string Name { get; set; }
        public string Logo { get; set; }

        private Restaurant(Guid id, string name, string logo)
        {
            Id = id;
            Name = name;
            Logo = logo;
        }

        internal void Initialize()
        {
            InitializeBase();
        }

        public static Restaurant Of(Guid id, string name, string logo)
        {
            return new Restaurant(id, name, logo);
        }
    }
}
