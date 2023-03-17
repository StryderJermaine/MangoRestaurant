using static Mango.Web.Constants;

namespace Mango.Web.Models;

/// <summary>
/// API request model class
/// </summary>
public class ApiRequest
{
    /// <summary>
    /// <see cref="ApiType"/> for the request
    /// </summary>
    public ApiType ApiType { get; set; } = ApiType.GET;

    /// <summary>
    /// Url for the request
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Request data
    /// </summary>
    public object? Data { get; set; }

    /// <summary>
    /// Access token for the request
    /// </summary>
    public string AccessToken { get; set; }
}