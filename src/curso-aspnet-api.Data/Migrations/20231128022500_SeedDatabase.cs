using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace curso_aspnet_api.Data.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f03ee786-92c0-489d-96e4-65ff68e19541"));

            migrationBuilder.CreateTable(
                name: "Ufs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Sigla = table.Column<string>(maxLength: 2, nullable: false),
                    Nome = table.Column<string>(maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ufs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(maxLength: 60, nullable: false),
                    CodIBGE = table.Column<int>(nullable: false),
                    UfId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipios_Ufs_UfId",
                        column: x => x.UfId,
                        principalTable: "Ufs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ceps",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Cep = table.Column<string>(maxLength: 10, nullable: false),
                    Logradouro = table.Column<string>(maxLength: 60, nullable: false),
                    Numero = table.Column<string>(maxLength: 10, nullable: false),
                    MunicipioId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ceps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ceps_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ufs",
                columns: new[] { "Id", "CreateAt", "Nome", "Sigla", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926ef"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2461), "Acre", "AC", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926d6"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2660), "Sergipe", "SE", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926d7"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2657), "São Paulo", "SP", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926d8"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2654), "Santa Catarina", "SC", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926d9"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2651), "Roraima", "RR", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926da"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2648), "Rondônia", "RO", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926db"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2645), "Rio Grande do Sul", "RS", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926dc"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2641), "Rio Grande do Norte", "RN", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926dd"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2638), "Rio de Janeiro", "RJ", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926de"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2635), "Piauí", "PI", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926df"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2633), "Pernambuco", "PE", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926e0"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2630), "Paraná", "PR", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926e1"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2627), "Paraíba", "PB", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926e2"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2623), "Pará", "PA", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926e3"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2621), "Minas Gerais", "MG", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926e4"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2618), "Mato Grosso do Sul", "MS", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926e5"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2615), "Mato Grosso", "MT", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926e6"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2612), "Maranhão", "MA", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926e7"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2608), "Goiás", "GO", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926e8"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2605), "Espírito Santo", "ES", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926e9"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2602), "Distrito Federal", "DF", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926ea"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2599), "Ceará", "CE", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926eb"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2596), "Bahia", "BA", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926ec"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2592), "Amazonas", "AM", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926ed"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2589), "Amapá", "AP", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926ee"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2584), "Alagoas", "AL", null },
                    { new Guid("f899b424-4d4d-4d03-9787-c156cdd926d5"), new DateTime(2023, 11, 27, 23, 25, 0, 232, DateTimeKind.Local).AddTicks(2663), "Tocantins", "TO", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("25a3df87-f0f4-400b-bbb2-4765b0832bbc"), new DateTime(2023, 11, 27, 23, 25, 0, 223, DateTimeKind.Local).AddTicks(4558), "admin@gmail.com", "Admin", new DateTime(2023, 11, 27, 23, 25, 0, 229, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.CreateIndex(
                name: "IX_Ceps_Cep",
                table: "Ceps",
                column: "Cep",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ceps_MunicipioId",
                table: "Ceps",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_CodIBGE",
                table: "Municipios",
                column: "CodIBGE");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_UfId",
                table: "Municipios",
                column: "UfId");

            migrationBuilder.CreateIndex(
                name: "IX_Ufs_Sigla",
                table: "Ufs",
                column: "Sigla",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ceps");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "Ufs");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25a3df87-f0f4-400b-bbb2-4765b0832bbc"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("f03ee786-92c0-489d-96e4-65ff68e19541"), new DateTime(2023, 11, 26, 12, 55, 13, 396, DateTimeKind.Local).AddTicks(4237), "admin@gmail.com", "Admin", new DateTime(2023, 11, 26, 12, 55, 13, 400, DateTimeKind.Local).AddTicks(3783) });
        }
    }
}
