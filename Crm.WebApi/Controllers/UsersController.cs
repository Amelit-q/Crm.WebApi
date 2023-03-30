using Crm.WebApi.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Crm.WebApi.Controllers;

[ApiController]
[Route("/api/users")]
public class UsersController : ControllerBase
{
    public IActionResult CreateUser([FromBody] UserDto createUserDto)
    {
        
    }
}
