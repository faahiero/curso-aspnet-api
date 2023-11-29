using System.Threading.Tasks;
using curso_aspnet_api.Domain.Entities;

namespace curso_aspnet_api.Domain.Interfaces.Repository.User
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> FindByLogin(string email);
    }
}