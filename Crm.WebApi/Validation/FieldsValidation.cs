namespace Crm.WebApi.Validation;

public class FieldsValidation : System.Attribute
{
    // TODO: Figure how to implement attribute
    
    private Guid Id;

    public void EmptyGuidAttribute(Guid id)
    {
        if (id != Guid.Empty)
        {
            Id = id;
        }
        
    }

    public Guid GetId() => Id;
}
