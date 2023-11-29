using System.Threading.Tasks;
using curso_aspnet_api.Domain.Dtos;
using curso_aspnet_api.Domain.Entities;

namespace curso_aspnet_api.Domain.Interfaces.Services.User
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto userDto);
    }
}