using Shared.Dtos;

namespace AgileMini.Data;

public class User
{

    public User(UserDto t)
    {
        Id = t.Id;
        Name = t.Name;
        Email = t.Email;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}