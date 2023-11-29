using System;
using System.Threading.Tasks;
using curso_aspnet_api.Domain.Entities;

namespace curso_aspnet_api.Domain.Interfaces.Repository.Cep
{
    public interface ICepRepository : IRepository<CepEntity>
    {
        Task<CepEntity> SelectAsync(string cep);
    }
}