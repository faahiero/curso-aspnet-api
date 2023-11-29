using System;
using curso_aspnet_api.Domain.Dtos.Uf;

namespace curso_aspnet_api.Domain.Dtos.Municipio
{
    public class MunicipioCompletoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int CodIBGE { get; set; }
        public Guid UfId { get; set; }
        public UfDto Uf { get; set; }
    }
}