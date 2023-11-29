using System;
using curso_aspnet_api.Domain.Dtos.Municipio;

namespace curso_aspnet_api.Domain.Dtos.Cep
{
    public class CepDto
    {
        public Guid Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public Guid MunicipioId { get; set; }
        public MunicipioCompletoDto Municipio { get; set; }
    }
}