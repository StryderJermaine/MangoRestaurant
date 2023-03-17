using Mango.Web.Models;

namespace Mango.Web.Services.Interfaces;

/// <summary>
/// Generic base service interface
/// </summary>
public interface IBaseService : IDisposable
{
    /// <summary>
    /// 
    /// </summary>
    ResponseDto responseModel { get; set; }

    /// <summary>
    /// Method to send an api request
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="apiRequest"></param>
    /// <returns></returns>
    Task<T> SendAsync<T>(ApiRequest apiRequest);
}