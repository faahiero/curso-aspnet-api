using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using curso_aspnet_api.Domain.Dtos.Uf;
using curso_aspnet_api.Domain.Interfaces.Repository.Uf;
using curso_aspnet_api.Domain.Interfaces.Services.Uf;

namespace curso_aspnet_api.Service.Services.Uf
{
    public class UfService : IUfService
    {
        private readonly IUfRepository _ufRepository;
        private readonly IMapper _mapper;

        public UfService(IUfRepository ufRepository, IMapper mapper)
        {
            _ufRepository = ufRepository;
            _mapper = mapper;
        }

        public async Task<UfDto> Get(Guid id)
        {
            var ufEntityResult = await _ufRepository.SelectAsync(id);
            var ufDtoResult = _mapper.Map<UfDto>(ufEntityResult);
            return ufDtoResult;
        }

        public async Task<IEnumerable<UfDto>> GetAll()
        {
            var ufEntityListResult = await _ufRepository.SelectAsync();
            var ufDtoListResult = _mapper.Map<IEnumerable<UfDto>>(ufEntityListResult);
            return ufDtoListResult;
        }
    }
}