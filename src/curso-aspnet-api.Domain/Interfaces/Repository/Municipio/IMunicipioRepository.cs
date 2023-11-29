using System;
using System.Threading.Tasks;
using curso_aspnet_api.Domain.Entities;

namespace curso_aspnet_api.Domain.Interfaces.Repository.Municipio
{
    public interface IMunicipioRepository : IRepository<MunicipioEntity>
    {
        Task<MunicipioEntity> GetCompleteById(Guid id);
        Task<MunicipioEntity> GetCompleteByIBGE(int codIBGE);
    }
}