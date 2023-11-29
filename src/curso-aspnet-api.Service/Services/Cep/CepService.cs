using System;
using System.Threading.Tasks;
using AutoMapper;
using curso_aspnet_api.Domain.Dtos.Cep;
using curso_aspnet_api.Domain.Entities;
using curso_aspnet_api.Domain.Interfaces.Repository.Cep;
using curso_aspnet_api.Domain.Interfaces.Services.Cep;
using curso_aspnet_api.Domain.Models;

namespace curso_aspnet_api.Service.Services.Cep
{
    public class CepService : ICepService
    {
        private readonly ICepRepository _cepRepository;
        private readonly IMapper _mapper;

        public CepService(ICepRepository cepRepository, IMapper mapper)
        {
            _cepRepository = cepRepository;
            _mapper = mapper;
        }

        public async Task<CepDto> Get(Guid id)
        {
            var cepEntityResult = await _cepRepository.SelectAsync(id);
            var cepDtoResult = _mapper.Map<CepDto>(cepEntityResult);
            return cepDtoResult;
        }

        public async Task<CepDto> Get(string cep)
        {
            var cepEntityResult = await _cepRepository.SelectAsync(cep);
            var cepDtoResult = _mapper.Map<CepDto>(cepEntityResult);
            return cepDtoResult;
        }

        public async Task<CepCreateResultDto> Post(CepCreateDto cep)
        {
            var cepModelResult = _mapper.Map<CepModel>(cep);
            var cepEntityResult = await _cepRepository.InsertAsync(_mapper.Map<CepEntity>(cepModelResult));

            var cepCreateResultDtoRes = _mapper.Map<CepCreateResultDto>(cepEntityResult);
            return cepCreateResultDtoRes;
        }

        public async Task<CepUpdateResultDto> Put(CepUpdateDto cep)
        {
            var cepModelResult = _mapper.Map<CepModel>(cep);
            var cepEntityResult = await _cepRepository.UpdateAsync(_mapper.Map<CepEntity>(cepModelResult));

            var cepUpdateResultDtoRes = _mapper.Map<CepUpdateResultDto>(cepEntityResult);
            return cepUpdateResultDtoRes;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _cepRepository.DeleteAsync(id);
        }
    }
}