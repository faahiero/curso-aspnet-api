using AutoMapper;
using curso_aspnet_api.Domain.Entities;
using curso_aspnet_api.Domain.Models;

namespace curso_aspnet_api.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserModel, UserEntity>().ReverseMap();
            CreateMap<UfModel, UfEntity>().ReverseMap();
            CreateMap<MunicipioModel, MunicipioEntity>().ReverseMap();
            CreateMap<CepModel, CepEntity>().ReverseMap();

        }
    }
}