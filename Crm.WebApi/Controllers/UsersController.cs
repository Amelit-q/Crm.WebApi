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
        UsersStore.UsersList.Add(createUserDto);
        return Ok();
    }
}
