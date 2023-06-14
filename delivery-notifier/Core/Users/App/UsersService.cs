using Core.Users.App.DTO;
using Core.Users.Domain.Services;

namespace Core.Users.App
{
    public class UsersService
    {
        private readonly IUsersRepository repository;

        public UsersService(IUsersRepository usersRepository)
        {
            this.repository = usersRepository;
        }

        public UserDTO CreateUser(CreateUserDTO dto)
        {
            var model = dto.ToModel();
            model.Initialize();
            repository.Save(model);
            repository.CommitChanges();
            return UserDTO.Of(model);
        }
    }
}
