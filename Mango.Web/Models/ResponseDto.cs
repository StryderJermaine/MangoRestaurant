namespace Mango.Web.Models;

/// <summary>
/// Dto class for API response
/// </summary>
public class ResponseDto
{
    /// <summary>
    /// Response state
    /// </summary>
    public bool IsSuccessful { get; set; } = true;

    /// <summary>
    /// Response object/data
    /// </summary>
    public object Result { get; set; }

    /// <summary>
    /// Response message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// List of errors
    /// </summary>
    public List<string> Errors { get; set; }
}