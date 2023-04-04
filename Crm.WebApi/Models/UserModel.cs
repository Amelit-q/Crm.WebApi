namespace Crm.WebApi.Models;

public class UserModel
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime DateModified { get; set; }

    public string Location { get; set; }

    public string Description { get; set; }
}
