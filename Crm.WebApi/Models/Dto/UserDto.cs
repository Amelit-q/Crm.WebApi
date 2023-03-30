using System.ComponentModel.DataAnnotations;

namespace Crm.WebApi.Models.Dto;

public class UserDto
{
    public class GetUserDto
    {
        public Guid Id { get; set; }


        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }


        public string Location { get; set; }

        public string Description { get; set; }
    }

    public class CreateUserDto
    {
        [Required, MaxLength(228)] public string Name { get; set; }

        [Required] public int Age { get; set; }

        [Required, MaxLength(228)] public string Location { get; set; }

        public string Description { get; set; }
    }
}
