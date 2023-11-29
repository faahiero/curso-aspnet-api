using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using curso_aspnet_api.Domain.Dtos.Uf;

namespace curso_aspnet_api.Domain.Interfaces.Services.Uf
{
    public interface IUfService
    {
        Task<UfDto> Get(Guid id);
        Task<IEnumerable<UfDto>> GetAll();
    }
}