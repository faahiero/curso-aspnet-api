using System.Threading.Tasks;
using curso_aspnet_api.Data.Context;
using curso_aspnet_api.Domain.Entities;
using curso_aspnet_api.Domain.Interfaces.Repository.Cep;
using Microsoft.EntityFrameworkCore;

namespace curso_aspnet_api.Data.Repository.Cep
{
    public class CepRepository : BaseRepository<CepEntity>, ICepRepository
    {
        private DbSet<CepEntity> _dataset;
        public CepRepository(ApiDataContext context) : base(context)
        {
            _dataset = context.Set<CepEntity>();
        }

        public async Task<CepEntity> SelectAsync(string cep)
        {
            var cepResult = await _dataset.Include(c => c.Municipio)
                .ThenInclude(m => m.Uf)
                .FirstOrDefaultAsync(c => c.Cep.Equals(cep));
            return cepResult;
        }
    }
}