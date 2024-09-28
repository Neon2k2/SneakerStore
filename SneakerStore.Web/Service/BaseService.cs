using SneakerStore.Web.Models;
using System.Text;
using Newtonsoft.Json;
using static SneakerStore.Web.Utility.SD;
using System.Net;

namespace SneakerStore.Web.Service
{
    public class BaseService : IBaseService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BaseService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ResponseDto?> SendAsync(RequestDto requestdto)
        {
            HttpClient client = _httpClientFactory.CreateClient("SneakerAPI");


             //Request Handling 
            HttpRequestMessage message = new();
            message.Headers.Add("Accept", "application/json");
            //token
            Console.WriteLine(requestdto.Url);
            message.RequestUri = new Uri(requestdto.Url);
            if (requestdto != null && requestdto.Data != null)
            {
                message.Content = new StringContent(JsonConvert.SerializeObject(requestdto.Data), Encoding.UTF8, "application/json");
            }


            
            //Response Handling
            HttpResponseMessage? apiResponse = null;

            switch(requestdto.ApiType)
            {
                case ApiType.POST:
                    message.Method = HttpMethod.Post;
                    break;
                case ApiType.PUT:
                    message.Method = HttpMethod.Put;
                    break;
                case ApiType.DELETE:
                    message.Method = HttpMethod.Delete;
                    break;
                default:
                    message.Method = HttpMethod.Get;
                    break;
            }
            Console.WriteLine(message);
            apiResponse = await client.SendAsync(message);

            try
            {
                switch (apiResponse.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        return new() { IsSuccess = false, Message = "Not Found" };
                    case HttpStatusCode.Unauthorized:
                        return new() { IsSuccess = false, Message = "Unauthorized" };
                    case HttpStatusCode.Forbidden:
                        return new() { IsSuccess = false, Message = "Access Denied" };
                    case HttpStatusCode.InternalServerError:
                        return new() { IsSuccess = false, Message = "Internal Server Error" };
                    default:
                        var apiContent = await apiResponse.Content.ReadAsStringAsync();
                        var apiResponseDto = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
                        return apiResponseDto;
                }
            } catch ( Exception ex)
            {
                var dto = new ResponseDto
                {
                    Message = ex.Message.ToString(),
                    IsSuccess = false
                };
                return dto;
            }
               
        }
    }
}
