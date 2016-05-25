using CExtensions.EFModelGenerator.Core;

namespace CExtensions.EFModelGenerator.Common
{
    public interface IForeignKey
    {
        Column Column { get; set; }
        string ColumnCLRType { get; }
        string ColumnName { get; }
        string Comment { get; }
        string ForeignKeyName { get; }
        string PropertyName { get; }
        string ReferencedCLRName { get; }
    }
}