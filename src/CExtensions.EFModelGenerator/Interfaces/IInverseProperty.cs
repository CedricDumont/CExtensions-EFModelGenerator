namespace CExtensions.EFModelGenerator.Common
{
    public interface IInverseProperty
    {
        string PropertyName { get; set; }
        string ReverseCLRType { get; set; }
        string ReversePropertyName { get; set; }
    }
}