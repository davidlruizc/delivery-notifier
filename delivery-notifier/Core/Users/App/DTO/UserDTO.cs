using Utilities.Domain;

namespace Core.Users.App.DTO
{
    public class UserDTO : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        private UserDTO(Guid id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public static UserDTO Of(Domain.Model.Users model)
        {
            return new UserDTO(model.Id, model.Name, model.Email);
        }
    }
}
