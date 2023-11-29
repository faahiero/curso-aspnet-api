using System;
using System.Threading.Tasks;
using curso_aspnet_api.Domain.Dtos.Cep;

namespace curso_aspnet_api.Domain.Interfaces.Services.Cep
{
    public interface ICepService
    {
        Task<CepDto> Get(Guid id);
        Task<CepDto> Get(string cep);

        Task<CepCreateResultDto> Post(CepCreateDto cep);

        Task<CepUpdateResultDto> Put(CepUpdateDto cep);

        Task<bool> Delete(Guid id);
    }
}