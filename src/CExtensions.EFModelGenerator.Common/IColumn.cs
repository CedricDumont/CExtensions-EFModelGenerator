namespace CExtensions.EFModelGenerator.Common
{
    public interface IColumn    
    {
        string CLRType { get; }
        string DBDataScale { get; set; }
        string DBType { get; set; }
        ITable ForeignTable { get; set; }
        string FormattedName { get; }
        bool IsForeignKey { get; set; }
        bool IsNullable { get; }
        bool IsPrimaryKey { get; set; }
        bool IsRequired { get; }
        string Name { get; }
        ITable Table { get; }
    }
}