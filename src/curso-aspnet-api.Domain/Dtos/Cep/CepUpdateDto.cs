using System;
using System.ComponentModel.DataAnnotations;

namespace curso_aspnet_api.Domain.Dtos.Cep
{
    public class CepUpdateDto
    {
        [Required(ErrorMessage = "Id é campo obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "CEP é campo obrigatório")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Logradouro é campo obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Número é campo obrigatório")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Município é campo obrigatório")]
        public Guid MunicipioId { get; set; }
    }
}