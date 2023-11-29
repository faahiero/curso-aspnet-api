using System;

namespace curso_aspnet_api.Domain.Dtos.Municipio
{
    public class MunicipioDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int CodIBGE { get; set; }

        public Guid UfId { get; set; }
    }
}