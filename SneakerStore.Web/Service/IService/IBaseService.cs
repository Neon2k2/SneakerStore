using SneakerStore.Web.Models;

namespace SneakerStore.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestdto, bool withBearer = true);
    }
}
