using System;
using System.ComponentModel.DataAnnotations;

namespace curso_aspnet_api.Domain.Dtos.Municipio
{
    public class MunicipioCreateDto
    {
        [Required(ErrorMessage = "Nome do município é campo obrigatório")]
        [MaxLength(60, ErrorMessage = "Nome do município deve ter no máximo {1} caracteres")]
        public string Nome { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Código IBGE inválido")]
        public int CodIBGE { get; set; }

        [Required(ErrorMessage = "Código da UF é campo obrigatório")]
        public Guid UfId { get; set; }
    }
}