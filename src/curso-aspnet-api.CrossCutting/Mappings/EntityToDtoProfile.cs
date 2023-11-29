using AutoMapper;
using curso_aspnet_api.Domain.Dtos.Cep;
using curso_aspnet_api.Domain.Dtos.Municipio;
using curso_aspnet_api.Domain.Dtos.Uf;
using curso_aspnet_api.Domain.Dtos.User;
using curso_aspnet_api.Domain.Entities;

namespace curso_aspnet_api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDto, UserEntity>().ReverseMap();
            CreateMap<UserCreateResultDto, UserEntity>().ReverseMap();
            CreateMap<UserUpdateResultDto, UserEntity>().ReverseMap();

            CreateMap<UfDto, UfEntity>().ReverseMap();

            CreateMap<MunicipioDto, MunicipioEntity>().ReverseMap();
            CreateMap<MunicipioCompletoDto, MunicipioEntity>().ReverseMap();
            CreateMap<MunicipioCreateResultDto, MunicipioEntity>().ReverseMap();
            CreateMap<MunicipioUpdateResultDto, MunicipioEntity>().ReverseMap();

            CreateMap<CepDto, CepEntity>().ReverseMap();
            CreateMap<CepCreateResultDto, CepEntity>().ReverseMap();
            CreateMap<CepUpdateResultDto, CepEntity>().ReverseMap();
        }
    }
}