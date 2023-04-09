using Crm.WebApi.Data;
using Crm.WebApi.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Crm.WebApi.Controllers;

[ApiController]
[Route("/api/users")]
public class UsersController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CreateUser([FromBody] UserDto.CreateUserDto createUserDto)
    {
        var user = new UserDto.CreateUserDto
        {
            Id = Guid.NewGuid(),
            Age = createUserDto.Age,
            Description = createUserDto.Description,
            Location = createUserDto.Location,
            Name = createUserDto.Name,
            CreatedAt = DateTime.UtcNow
        };


        UsersStore.UsersList.Add(user);

        return Ok(user);
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetUsers()
    {
        var entities = UsersStore.UsersList.ToList();
        return Ok(entities);
    }
}
