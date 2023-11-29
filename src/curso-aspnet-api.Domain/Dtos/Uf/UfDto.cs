using System;

namespace curso_aspnet_api.Domain.Dtos.Uf
{
    public class UfDto
    {
        public Guid Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
    }
}