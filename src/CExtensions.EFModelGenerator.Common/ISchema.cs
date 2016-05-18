using System.Collections.Generic;

namespace CExtensions.EFModelGenerator.Common
{
    public interface ISchema
    {
        /// <summary>
        /// Name of the schema
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Access to all columns of the schema
        /// </summary>
        List<IColumn> AllColumns { get; }

        /// <summary>
        /// Access all tables of the schema
        /// </summary>
        List<ITable> Tables { get; set; }


    }
}