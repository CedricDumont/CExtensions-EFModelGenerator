namespace CExtensions.EFModelGenerator.Interfaces
{
    public interface INameFormatter<T>
    {
        /// <summary>
        /// Does this formatter apply to this specific column
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        bool IsApplicable(T input, string currentName);

        /// <summary>
        /// return the name of the column.
        /// </summary>
        /// <param name="input">to get access to all columns properties</param>
        /// <returns></returns>
        string Apply(T input, string currentName);

        /// <summary>
        /// By default the framework cascades the formatters. 
        /// Implement this method to check if the subsequent formatters must be called.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        bool SkipOtherFormatters(T input, string currentName);
       

        
    }
}