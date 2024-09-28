using SneakerStore.Services.AuthAPI.Models;

namespace SneakerStore.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
