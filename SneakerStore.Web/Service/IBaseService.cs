using SneakerStore.Web.Models;

namespace SneakerStore.Web.Service
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestdto);
    }
}
