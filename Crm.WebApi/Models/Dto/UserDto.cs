using System.ComponentModel.DataAnnotations;
using Crm.WebApi.Validation;

namespace Crm.WebApi.Models.Dto;

public class UserDto
{
    public class GetUserDto
    {
        [NotEmpty] public Guid Id { get; set; }


        [NotEmpty] public string Name { get; set; }

        [NotEmpty] public int Age { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime DateModified { get; set; }


        public string Location { get; set; }

        public string Description { get; set; }
    }

    public class CreateUserDto
    {
        public Guid Id { get; set; }

        [NotEmpty]
        [MinLength(4)]
        [MaxLength(228)]
        public string Name { get; set; }

        [NotEmpty]
        [Range(14, 100,
            ErrorMessage = "The age requirement is a minimum of 14 years old and a maximum of 100 years old")]
        public int Age { get; set; }

        [NotEmpty] [MaxLength(228)] public string Location { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Description { get; set; }
    }
}
