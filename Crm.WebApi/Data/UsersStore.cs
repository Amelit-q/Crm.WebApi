using Crm.WebApi.Models.Dto;

namespace Crm.WebApi.Data;

public static class UsersStore
{
    public static List<UserDto.CreateUserDto> UsersList = new List<UserDto.CreateUserDto>
    {
        new UserDto.CreateUserDto
        {
            Age = 33, Description = "Random description for the random user", Name = "Random Name", Location = "Moscow",
            Id = new Guid(),
        },
        new UserDto.CreateUserDto
        {
            Age = 22, Description = "Random description for another random user", Name = "Another Random Name",
            Id = new Guid(),
            Location = "Leningrad",
        },
    };
}
