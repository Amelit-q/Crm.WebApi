using System.ComponentModel.DataAnnotations;

namespace Crm.WebApi.Validation;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Property | AttributeTargets.Parameter)]
public class NotEmptyAttribute : ValidationAttribute
{
    private static readonly DateTime EmptyDateTime = new DateTime();

    private static readonly Guid EmptyId = new Guid();

    public NotEmptyAttribute() : base("The {0} field is required")
    {
    }

    public override bool IsValid(object value) =>
        value switch
        {
            null => false,
            string stringValue when string.IsNullOrEmpty(stringValue) => false,
            Guid guidValue when guidValue == EmptyId => false,
            // Guid guidValue when guidValue == Guid.Empty => false,
            DateTime dateTime when dateTime == EmptyDateTime => false,
            _ => false
        };
}
