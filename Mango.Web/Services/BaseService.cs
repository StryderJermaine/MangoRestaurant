using Mango.Web.Models;
using Mango.Web.Services.Interfaces;
using System.Text;
using System.Text.Json;

namespace Mango.Web.Services;

/// <summary>
/// Generic base service class
/// </summary>
public class BaseService : IBaseService
{
    public ResponseDto responseModel { get; set; }

    public IHttpClientFactory httpClient { get; set; }

    public BaseService(IHttpClientFactory httpClient)
    {
        this.httpClient = httpClient;
        this.responseModel = new ResponseDto();
    }

    public async Task<T> SendAsync<T>(ApiRequest apiRequest)
    {
        try
        {
            var client = httpClient.CreateClient("MangoAPI");

            var message = new HttpRequestMessage();

            message.Headers.Add("Accept", "application/json");

            message.RequestUri = new Uri(apiRequest.Url);

            client.DefaultRequestHeaders.Clear();

            if (apiRequest.Data != null)
            {
                message.Content = new StringContent(JsonSerializer.Serialize(apiRequest.Data), Encoding.UTF8,
                    "application/json");
            }

            switch (apiRequest.ApiType)
            {
                case Constants.ApiType.POST:
                    message.Method = HttpMethod.Post;
                    break;

                case Constants.ApiType.PUT:
                    message.Method = HttpMethod.Put;
                    break;

                case Constants.ApiType.DELETE:
                    message.Method = HttpMethod.Delete;
                    break;

                default:
                    message.Method = HttpMethod.Get;
                    break;
            }

            var apiResponse = await client.SendAsync(message);

            var apiContent = await apiResponse.Content.ReadAsStringAsync();

            var apiResponseDto = JsonSerializer.Deserialize<T>(apiContent);

            return apiResponseDto;
        }
        catch (Exception e)
        {
            var dto = new ResponseDto
            {
                Message = "Error",
                Errors = new List<string> { e.Message },
                IsSuccessful = false
            };

            var response = JsonSerializer.Serialize(dto);

            var apiResponseDto = JsonSerializer.Deserialize<T>(response);

            return apiResponseDto;
        }
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}