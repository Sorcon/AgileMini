using Shared.Dtos;

using System.Text.Json;

namespace AgileMini.Data;

public class DataService
{
    string Base = "https://localhost:7184/"; //TODO: вынести в конфиг
    string UsersBase = "{Base}/users";
    public async Task<Project[]?> GetProjects()
    {
        return Array.Empty<Project>();
    }

    public async Task<TaskVM[]?> GetTasks()
    {
        return Array.Empty<TaskVM>();

    }

    public async Task<User[]?> GetUsers()
    {
        var client = new HttpClient();
        var result = await client.GetAsync(UsersBase);
        User[]? users = null;
        if (result.IsSuccessStatusCode)
        {
            using var responseStream = await result.Content.ReadAsStreamAsync();
            users = (await JsonSerializer.DeserializeAsync
                <UserDto[]>(responseStream))?.Select(t=>new User(t)).ToArray();
        }
        return users;
    }


    public async Task<Project[]?> GetActiveProjects()
    {
        return Array.Empty<Project>();

    }

    public async Task<User[]?> GetUnemployedUsers()
    {
        return Array.Empty<User>();

    }

    public async Task AddUser(User user)
    {
        
    }

    public async Task EditUser(User user)
    {
        
    }
    
    public async Task AddProject(Project user)
    {
        
    }

    public async Task EditProject(Project user)
    {
        
    }
    
    public async Task AddTask(TaskVM user)
    {
        
    }

    public async Task EditTask(TaskVM user)
    {
        
    }


    public User GetUser(int userId)
    {
        throw new NotImplementedException();
    }
}