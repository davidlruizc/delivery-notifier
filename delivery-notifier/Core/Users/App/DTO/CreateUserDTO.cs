namespace Core.Users.App.DTO
{
    public class CreateUserDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public CreateUserDTO(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public Domain.Model.Users ToModel()
        {
            var id = Guid.NewGuid();
            return Domain.Model.Users.Of(id, Name, Email);
        }
    }
}
