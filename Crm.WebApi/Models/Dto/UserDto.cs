using System.ComponentModel.DataAnnotations;

namespace Crm.WebApi.Models.Dto;

public class UserDto
{
    public Guid Id { get; set; }

    [Required]
    [MaxLength(228)]
    public string Name { get; set; }

    [Required]
    public int Age { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    [Required]
    [MaxLength(228)]
    public string Location { get; set; }

    public string Description { get; set; }
}
