using Utilities.Domain;

namespace Core.Users.Domain.Model
{
    public class Users : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        private Users(Guid id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
        internal void Initialize()
        {
            InitializeBase();
        }
        public static Users Of(Guid id, string name, string email)
        {
            return new Users(id, name, email);
        }
    }
}
