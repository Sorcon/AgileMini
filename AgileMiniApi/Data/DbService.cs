using Shared.Dtos;

namespace AgileMiniApi.Data;

public class DbService
{
    public IEnumerable<UserDto> GetUsers()
    {
        using (var dbContext = new DataBaseContext())
        {
            return dbContext.Users.Select(dbUser => dbUser.ToDto());
        }
    }
}