using System;
using System.Threading.Tasks;
using curso_aspnet_api.Data.Context;
using curso_aspnet_api.Domain.Entities;
using curso_aspnet_api.Domain.Interfaces.Repository.Municipio;
using Microsoft.EntityFrameworkCore;

namespace curso_aspnet_api.Data.Repository.Municipio
{
    public class MunicipioRepository : BaseRepository<MunicipioEntity>, IMunicipioRepository
    {
        private DbSet<MunicipioEntity> _dataset;
        public MunicipioRepository(ApiDataContext context) : base(context)
        {
            _dataset = context.Set<MunicipioEntity>();
        }

        public async Task<MunicipioEntity> GetCompleteById(Guid id)
        {
            var municipioById = await _dataset.Include(u => u.Uf)
                .FirstOrDefaultAsync(m => m.Id.Equals(id));
            return municipioById;
        }

        public async Task<MunicipioEntity> GetCompleteByIBGE(int codIBGE)
        {
            var municipioByIbge = await _dataset.Include(u => u.Uf)
                .FirstOrDefaultAsync(m => m.CodIBGE == codIBGE);
            return municipioByIbge;
        }
    }
}