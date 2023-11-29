using System;
using curso_aspnet_api.Data.Mapping;
using curso_aspnet_api.Data.Seeds;
using curso_aspnet_api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace curso_aspnet_api.Data.Context
{
    public class ApiDataContext : DbContext
    {
        public ApiDataContext(DbContextOptions<ApiDataContext> options) : base(options)
        {

        }

        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.ApplyConfiguration(new CepMap());
            modelBuilder.ApplyConfiguration(new MunicipioMap());
            modelBuilder.ApplyConfiguration(new UfMap());

            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Admin",
                    Email = "admin@gmail.com",
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                });

            UfSeeds.Ufs(modelBuilder);
        }
    }
}