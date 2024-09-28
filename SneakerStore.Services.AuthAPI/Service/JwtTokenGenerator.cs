using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SneakerStore.Services.AuthAPI.Models;
using SneakerStore.Services.AuthAPI.Service.IService;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SneakerStore.Services.AuthAPI.Service
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly JwtOptions _jwtoptions;

        public JwtTokenGenerator(IOptions<JwtOptions> jwtoptions) {
            _jwtoptions = jwtoptions.Value;
        }
        public string GenerateToken(ApplicationUser applicationUser)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_jwtoptions.Secret);
            var claimList = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Email, applicationUser.Email),
                new Claim(JwtRegisteredClaimNames.Sub, applicationUser.Id),
                new Claim(JwtRegisteredClaimNames.Email, applicationUser.UserName),
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Audience = _jwtoptions.Audience,
                Issuer = _jwtoptions.Issuer,
                Subject = new ClaimsIdentity(claimList),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)

            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);

        }
    }
}
