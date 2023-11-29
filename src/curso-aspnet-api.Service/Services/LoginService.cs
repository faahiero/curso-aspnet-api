using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using curso_aspnet_api.Domain.Dtos;
using curso_aspnet_api.Domain.Interfaces.Repository.User;
using curso_aspnet_api.Domain.Interfaces.Services.User;
using curso_aspnet_api.Domain.Security;
using Microsoft.IdentityModel.Tokens;

namespace curso_aspnet_api.Service.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _repository;
        private readonly SigningConfiguration _signingConfiguration;
        private readonly TokenConfiguration _tokenConfiguration;

        public LoginService(IUserRepository repository, SigningConfiguration signingConfiguration, TokenConfiguration tokenConfiguration)
        {
            _repository = repository;
            _signingConfiguration = signingConfiguration;
            _tokenConfiguration = tokenConfiguration;
        }

        public async Task<object> FindByLogin(LoginDto userDto)
        {
            if (userDto == null || string.IsNullOrWhiteSpace(userDto.Email))
            {
                return null;
            }

            var baseUser = await _repository.FindByLogin(userDto.Email);
            if (baseUser == null)
            {
                return new { authenticated = false, message = "Falha ao autenticar" };
            }

            var identity = new ClaimsIdentity(
                new GenericIdentity(baseUser.Email),
                new[]
                {
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.UniqueName, baseUser.Email),
                });

            var createDate = DateTime.Now;
            var expirationDate = createDate + TimeSpan.FromSeconds(_tokenConfiguration.Seconds);

            var handler = new JwtSecurityTokenHandler();
            var token = CreateToken(identity, createDate, expirationDate, handler);

            return new
            {
                authenticated = true,
                created = createDate.ToString("yyyy-MM-dd HH:mm:ss"),
                expiration = expirationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                accessToken = token,
                userName = userDto.Email,
                message = "Usuário logado com sucesso"
            };
        }

        private string CreateToken(ClaimsIdentity identity, DateTime createDate, DateTime expirationDate,
            JwtSecurityTokenHandler handler)
        {
            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _tokenConfiguration.Issuer,
                Audience = _tokenConfiguration.Audience,
                SigningCredentials = _signingConfiguration.SigningCredentials,
                Subject = identity,
                NotBefore = createDate,
                Expires = expirationDate
            });

            return handler.WriteToken(securityToken);
        }
    }
}