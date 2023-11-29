using AutoMapper;
using curso_aspnet_api.Domain.Dtos.Cep;
using curso_aspnet_api.Domain.Dtos.Municipio;
using curso_aspnet_api.Domain.Dtos.Uf;
using curso_aspnet_api.Domain.Dtos.User;
using curso_aspnet_api.Domain.Models;

namespace curso_aspnet_api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDto>().ReverseMap();
            CreateMap<UserModel, UserCreateDto>().ReverseMap();
            CreateMap<UserModel, UserUpdateDto>().ReverseMap();

            CreateMap<CepModel, CepDto>().ReverseMap();
            CreateMap<CepModel, CepCreateDto>().ReverseMap();
            CreateMap<CepModel, CepUpdateDto>().ReverseMap();

            CreateMap<MunicipioModel, MunicipioDto>().ReverseMap();
            CreateMap<MunicipioModel, MunicipioCreateDto>().ReverseMap();
            CreateMap<MunicipioModel, MunicipioUpdateDto>().ReverseMap();

            CreateMap<UfModel, UfDto>().ReverseMap();


        }
    }
}