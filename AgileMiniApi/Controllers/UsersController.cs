using AgileMiniApi.Data;
using Shared.Dtos;

namespace AgileMiniApi.Controllers;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UsersController: ControllerBase
{
    private readonly ILogger<UsersController> _logger;
    private DbService _dbService; 
    
    public UsersController(ILogger<UsersController> logger, DbService dbService)
    {
        _logger = logger;
        _dbService = dbService;
    }

    [HttpGet]
    public IEnumerable<UserDto> Get()
    {
        return _dbService.GetUsers();
    }
}





