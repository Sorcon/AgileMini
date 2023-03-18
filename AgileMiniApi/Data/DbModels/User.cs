using Shared.Dtos;

namespace AgileMiniApi.Data.DbModels
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public UserDto ToDto()
        {
            return new UserDto { Id = Id, Name = Name, Email = Email };
        }
    }
}
