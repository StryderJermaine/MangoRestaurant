namespace Mango.Web;

/// <summary>
/// Static class to hold application constants
/// </summary>
public static class Constants
{
    /// <summary>
    /// Constant prop to hold product api url 
    /// </summary>
    public static string ProductApiBase { get; set; }

    /// <summary>
    /// Api type enumeration
    /// </summary>
    public enum ApiType
    {
        /// <summary>
        /// Get request api type
        /// </summary>
        GET,
        /// <summary>
        /// Post request api type
        /// </summary>
        POST,
        /// <summary>
        /// Put request api type
        /// </summary>
        PUT,
        /// <summary>
        /// Delete request api type
        /// </summary>
        DELETE
    }
}