using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using curso_aspnet_api.Domain.Dtos.Municipio;

namespace curso_aspnet_api.Domain.Interfaces.Services.Municipio
{
    public interface IMunicipioService
    {
        Task<MunicipioDto> Get(Guid id);
        Task<MunicipioCompletoDto> GetCompleteById(Guid id);
        Task<MunicipioCompletoDto> GetCompleteByIBGE(int codIBGE);
        Task<IEnumerable<MunicipioDto>>GetAll();

        Task<MunicipioCreateResultDto> Post(MunicipioCreateDto municipio);

        Task<MunicipioUpdateResultDto> Put(MunicipioUpdateDto municipio);

        Task<bool> Delete(Guid id);
    }
}