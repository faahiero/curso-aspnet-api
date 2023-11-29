using System;
using curso_aspnet_api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace curso_aspnet_api.Data.Seeds
{
    public static class UfSeeds
    {
        public static void Ufs(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UfEntity>().HasData(
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926EF"), Nome = "Acre", Sigla = "AC", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926EE"), Nome = "Alagoas", Sigla = "AL", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926ED"), Nome = "Amapá", Sigla = "AP", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926EC"), Nome = "Amazonas", Sigla = "AM", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926EB"), Nome = "Bahia", Sigla = "BA", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926EA"), Nome = "Ceará", Sigla = "CE", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926E9"), Nome = "Distrito Federal", Sigla = "DF", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926E8"), Nome = "Espírito Santo", Sigla = "ES", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926E7"), Nome = "Goiás", Sigla = "GO", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926E6"), Nome = "Maranhão", Sigla = "MA", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926E5"), Nome = "Mato Grosso", Sigla = "MT", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926E4"), Nome = "Mato Grosso do Sul", Sigla = "MS", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926E3"), Nome = "Minas Gerais", Sigla = "MG", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926E2"), Nome = "Pará", Sigla = "PA", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926E1"), Nome = "Paraíba", Sigla = "PB", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926E0"), Nome = "Paraná", Sigla = "PR", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926DF"), Nome = "Pernambuco", Sigla = "PE", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926DE"), Nome = "Piauí", Sigla = "PI", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926DD"), Nome = "Rio de Janeiro", Sigla = "RJ", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926DC"), Nome = "Rio Grande do Norte", Sigla = "RN", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926DB"), Nome = "Rio Grande do Sul", Sigla = "RS", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926DA"), Nome = "Rondônia", Sigla = "RO", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926D9"), Nome = "Roraima", Sigla = "RR", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926D8"), Nome = "Santa Catarina", Sigla = "SC", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926D7"), Nome = "São Paulo", Sigla = "SP", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926D6"), Nome = "Sergipe", Sigla = "SE", CreateAt = DateTime.Now },
                new UfEntity { Id = new Guid("F899B424-4D4D-4D03-9787-C156CDD926D5"), Nome = "Tocantins", Sigla = "TO", CreateAt = DateTime.Now }
            );
        }
    }
}