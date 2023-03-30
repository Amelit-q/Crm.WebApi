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
        if (createUserDto.Age < 14)
        {
            return BadRequest("The age must be at least 14 year old");
        }

        if (createUserDto.Name.Length == 0)
        {
            return BadRequest("Username field must be not null");
        }

        if (createUserDto.Id == Guid.Empty)
        {
            createUserDto.Id = Guid.NewGuid();
        }


        UsersStore.UsersList.Add(createUserDto);

        return CreatedAtAction(nameof(CreateUser), new { id = createUserDto.Id }, createUserDto);
    }
}
