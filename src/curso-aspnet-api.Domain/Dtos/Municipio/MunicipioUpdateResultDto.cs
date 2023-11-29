using System;
using System.ComponentModel.DataAnnotations;

namespace curso_aspnet_api.Domain.Dtos.Municipio
{
    public class MunicipioUpdateResultDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int CodIBGE { get; set; }
        public Guid UfId { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}