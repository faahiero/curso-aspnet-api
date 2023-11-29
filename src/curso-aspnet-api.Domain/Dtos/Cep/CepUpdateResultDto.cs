using System;
using System.ComponentModel.DataAnnotations;

namespace curso_aspnet_api.Domain.Dtos.Cep
{
    public class CepUpdateResultDto
    {
        public Guid Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public Guid MunicipioId { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}