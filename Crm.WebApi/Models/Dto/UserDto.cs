using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

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
        public Guid Id { get; set; }

        [Required, MaxLength(228)] public string Name { get; set; }

        // [Required, Range(14, 100, ErrorMessage = "The age requirement is a minimum of 14 years old and a maximum of 100 years old")]
        [Required, Range(14, 100, ErrorMessage = "The age requirement is a minimum of 14 years old and a maximum of 100 years old")]
        public int Age { get; set; }

        [Required, MaxLength(228)] public string Location { get; set; }

        public string Description { get; set; }
    }
}
