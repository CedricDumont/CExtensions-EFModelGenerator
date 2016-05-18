namespace CExtensions.EFModelGenerator.Common
{
    public interface IForeignKey
    {
        IColumn Column { get; set; }
        string ColumnCLRType { get; }
        string ColumnName { get; }
        string Comment { get; }
        string ForeignKeyName { get; }
        string PropertyName { get; }
        string ReferencedCLRName { get; }
    }
}