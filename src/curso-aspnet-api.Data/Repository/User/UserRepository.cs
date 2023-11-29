using System.Threading.Tasks;
using curso_aspnet_api.Data.Context;
using curso_aspnet_api.Domain.Entities;
using curso_aspnet_api.Domain.Interfaces.Repository.User;
using Microsoft.EntityFrameworkCore;

namespace curso_aspnet_api.Data.Repository.User
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        private new DbSet<UserEntity> _dataset;
        public UserRepository(ApiDataContext context) : base(context)
        {
            _dataset = _context.Set<UserEntity>();
        }

        public async Task<UserEntity> FindByLogin(string email)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }
    }
}