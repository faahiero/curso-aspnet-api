using curso_aspnet_api.Data.Context;
using curso_aspnet_api.Domain.Entities;
using curso_aspnet_api.Domain.Interfaces.Repository.Uf;
using Microsoft.EntityFrameworkCore;

namespace curso_aspnet_api.Data.Repository.Uf
{
    public class UfRepository : BaseRepository<UfEntity>, IUfRepository
    {
        private new DbSet<UfEntity> _dataset;
        public UfRepository(ApiDataContext context) : base(context)
        {
            _dataset = context.Set<UfEntity>();
        }
    }
}