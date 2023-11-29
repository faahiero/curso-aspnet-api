using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using curso_aspnet_api.Domain.Dtos.Municipio;
using curso_aspnet_api.Domain.Entities;
using curso_aspnet_api.Domain.Interfaces.Repository.Municipio;
using curso_aspnet_api.Domain.Interfaces.Services.Municipio;
using curso_aspnet_api.Domain.Models;

namespace curso_aspnet_api.Service.Services.Municipio
{
    public class MunicipioService : IMunicipioService
    {
        private readonly IMunicipioRepository _municipioRepository;
        private readonly IMapper _mapper;

        public MunicipioService(IMunicipioRepository municipioRepository, IMapper mapper)
        {
            _municipioRepository = municipioRepository;
            _mapper = mapper;
        }

        public async Task<MunicipioDto> Get(Guid id)
        {
            var municipioEntityResult = await _municipioRepository.SelectAsync(id);
            var municipioDtoResult = _mapper.Map<MunicipioDto>(municipioEntityResult);
            return municipioDtoResult;
        }

        public async Task<MunicipioCompletoDto> GetCompleteById(Guid id)
        {
            var municipioCompletoEntityResult = _municipioRepository.GetCompleteById(id);
            var municipioCompletoDtoResult = _mapper.Map<MunicipioCompletoDto>(municipioCompletoEntityResult);
            return municipioCompletoDtoResult;
        }

        public async Task<MunicipioCompletoDto> GetCompleteByIBGE(int codIBGE)
        {
            var municipioCompletoEntityResult = await _municipioRepository.GetCompleteByIBGE(codIBGE);
            var municipioCompletoDtoResult = _mapper.Map<MunicipioCompletoDto>(municipioCompletoEntityResult);
            return municipioCompletoDtoResult;
        }

        public async Task<IEnumerable<MunicipioDto>> GetAll()
        {
            var municipioEntityListResult = await _municipioRepository.SelectAsync();
            var municipioDtoListResult = _mapper.Map<IEnumerable<MunicipioDto>>(municipioEntityListResult);
            return municipioDtoListResult;
        }

        public async Task<MunicipioCreateResultDto> Post(MunicipioCreateDto municipio)
        {
            var municipioModelResult = _mapper.Map<MunicipioModel>(municipio);
            var municipioEntityResult =
                await _municipioRepository.InsertAsync(_mapper.Map<MunicipioEntity>(municipioModelResult));

            var municipioCreateResultDtoRes = _mapper.Map<MunicipioCreateResultDto>(municipioEntityResult);
            return municipioCreateResultDtoRes;
        }

        public async Task<MunicipioUpdateResultDto> Put(MunicipioUpdateDto municipio)
        {
            var municipioModelResult = _mapper.Map<MunicipioModel>(municipio);
            var municipioEntityResult =
                await _municipioRepository.UpdateAsync(_mapper.Map<MunicipioEntity>(municipioModelResult));

            var municipioUpdateResultDtoRes = _mapper.Map<MunicipioUpdateResultDto>(municipioEntityResult);
            return municipioUpdateResultDtoRes;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _municipioRepository.DeleteAsync(id);
        }
    }
}