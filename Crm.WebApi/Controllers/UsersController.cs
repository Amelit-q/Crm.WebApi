using Crm.WebApi.Data;
using Crm.WebApi.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Crm.WebApi.Controllers;

[ApiController]
[Route("/api/users")]
public class UsersController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult CreateUser([FromBody] UserDto.CreateUserDto createUserDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var user = new UserDto.CreateUserDto
        {
            Id = Guid.NewGuid(),
            Age = createUserDto.Age,
            Description = createUserDto.Description,
            Location = createUserDto.Location,
            Name = createUserDto.Name,
            DateCreated = DateTime.Now,
        };


        UsersStore.UsersList.Add(user);

        return Ok(user);
    }
}
