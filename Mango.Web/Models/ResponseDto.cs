using System.Text.Json.Serialization;

namespace Mango.Web.Models;

/// <summary>
/// Dto class for API response
/// </summary>
public class ResponseDto
{
    /// <summary>
    /// Response state
    /// </summary>
    [JsonPropertyName("isSuccessful")]
    public bool IsSuccessful { get; set; } = true;

    /// <summary>
    /// Response object/data
    /// </summary>
    [JsonPropertyName("result")]
    public object Result { get; set; }

    /// <summary>
    /// Response message
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>
    /// List of errors
    /// </summary>
    [JsonPropertyName("errors")]
    public List<string> Errors { get; set; }
}