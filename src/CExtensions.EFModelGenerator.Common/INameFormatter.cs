namespace CExtensions.EFModelGenerator.Common
{
    public interface INameFormatter<T>
    {
        /// <summary>
        /// Does this formatter apply to this specific column
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        bool IsApplicable(T input);

        /// <summary>
        /// return the name of the column.
        /// </summary>
        /// <param name="input">to get access to all columns properties</param>
        /// <returns></returns>
        string Apply(T input);

        
    }
}