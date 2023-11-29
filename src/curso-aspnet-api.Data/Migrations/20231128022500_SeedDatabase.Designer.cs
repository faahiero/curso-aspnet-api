﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using curso_aspnet_api.Data.Context;

namespace curso_aspnet_api.Data.Migrations
{
    [DbContext(typeof(ApiDataContext))]
    [Migration("20231128022500_SeedDatabase")]
    partial class SeedDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("curso_aspnet_api.Domain.Entities.CepEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<Guid>("MunicipioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Cep")
                        .IsUnique();

                    b.HasIndex("MunicipioId");

                    b.ToTable("Ceps");
                });

            modelBuilder.Entity("curso_aspnet_api.Domain.Entities.MunicipioEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CodIBGE")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<Guid>("UfId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CodIBGE");

                    b.HasIndex("UfId");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("curso_aspnet_api.Domain.Entities.UfEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Sigla")
                        .IsUnique();

                    b.ToTable("Ufs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926ef"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2461),
                            Nome = "Acre",
                            Sigla = "AC"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926ee"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2584),
                            Nome = "Alagoas",
                            Sigla = "AL"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926ed"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2589),
                            Nome = "Amapá",
                            Sigla = "AP"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926ec"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2592),
                            Nome = "Amazonas",
                            Sigla = "AM"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926eb"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2596),
                            Nome = "Bahia",
                            Sigla = "BA"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926ea"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2599),
                            Nome = "Ceará",
                            Sigla = "CE"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926e9"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2602),
                            Nome = "Distrito Federal",
                            Sigla = "DF"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926e8"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2605),
                            Nome = "Espírito Santo",
                            Sigla = "ES"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926e7"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2608),
                            Nome = "Goiás",
                            Sigla = "GO"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926e6"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2612),
                            Nome = "Maranhão",
                            Sigla = "MA"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926e5"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2615),
                            Nome = "Mato Grosso",
                            Sigla = "MT"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926e4"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2618),
                            Nome = "Mato Grosso do Sul",
                            Sigla = "MS"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926e3"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2621),
                            Nome = "Minas Gerais",
                            Sigla = "MG"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926e2"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2623),
                            Nome = "Pará",
                            Sigla = "PA"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926e1"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2627),
                            Nome = "Paraíba",
                            Sigla = "PB"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926e0"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2630),
                            Nome = "Paraná",
                            Sigla = "PR"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926df"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2633),
                            Nome = "Pernambuco",
                            Sigla = "PE"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926de"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2635),
                            Nome = "Piauí",
                            Sigla = "PI"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926dd"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2638),
                            Nome = "Rio de Janeiro",
                            Sigla = "RJ"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926dc"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2641),
                            Nome = "Rio Grande do Norte",
                            Sigla = "RN"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926db"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2645),
                            Nome = "Rio Grande do Sul",
                            Sigla = "RS"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926da"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2648),
                            Nome = "Rondônia",
                            Sigla = "RO"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926d9"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2651),
                            Nome = "Roraima",
                            Sigla = "RR"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926d8"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2654),
                            Nome = "Santa Catarina",
                            Sigla = "SC"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926d7"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2657),
                            Nome = "São Paulo",
                            Sigla = "SP"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926d6"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2660),
                            Nome = "Sergipe",
                            Sigla = "SE"
                        },
                        new
                        {
                            Id = new Guid("f899b424-4d4d-4d03-9787-c156cdd926d5"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2663),
                            Nome = "Tocantins",
                            Sigla = "TO"
                        });
                });

            modelBuilder.Entity("curso_aspnet_api.Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("25a3df87-f0f4-400b-bbb2-4765b0832bbc"),
                            CreateAt = new DateTime(2023, 11, 27, 23, 25, 0, 223, DateTimeKind.Local).AddTicks(4558),
                            Email = "admin@gmail.com",
                            Name = "Admin",
                            UpdateAt = new DateTime(2023, 11, 27, 23, 25, 0, 229, DateTimeKind.Local).AddTicks(9139)
                        });
                });

            modelBuilder.Entity("curso_aspnet_api.Domain.Entities.CepEntity", b =>
                {
                    b.HasOne("curso_aspnet_api.Domain.Entities.MunicipioEntity", "Municipio")
                        .WithMany("Ceps")
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("curso_aspnet_api.Domain.Entities.MunicipioEntity", b =>
                {
                    b.HasOne("curso_aspnet_api.Domain.Entities.UfEntity", "Uf")
                        .WithMany("Municipios")
                        .HasForeignKey("UfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
