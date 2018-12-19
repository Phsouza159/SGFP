using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGFP.Infra.Migrations
{
    public partial class mapEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Sigla = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SGFP_005_DOCUMENTO",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SGFP_006_EMAIL",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ENDERECO = table.Column<string>(type: "varchar(35)", nullable: false),
                    SENHA = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DDD = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    TipoTelefone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Sigla = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    PaisId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estado_Pais_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SGFP_003_CIDADE",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NOME = table.Column<string>(type: "varchar(35)", nullable: false),
                    EstadoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SGFP_003_CIDADE_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SGFP_007_ENDERECO",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CEP = table.Column<string>(type: "varchar(8)", nullable: true),
                    ENDERECO = table.Column<string>(type: "varchar(45)", nullable: false),
                    MUNICIPIO = table.Column<string>(type: "varchar(25)", nullable: false),
                    COMPLEMENTO = table.Column<string>(type: "varchar(45)", nullable: true),
                    CidadeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SGFP_007_ENDERECO_SGFP_003_CIDADE_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "SGFP_003_CIDADE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SGFP_002_CARRO",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DonoId = table.Column<Guid>(nullable: true),
                    PLACA = table.Column<string>(type: "varchar(8)", nullable: false),
                    CHASSI = table.Column<string>(type: "varchar(15)", nullable: false),
                    COR = table.Column<string>(type: "varchar(12)", nullable: false),
                    MARCA = table.Column<string>(type: "varchar(50)", nullable: false),
                    MODELO = table.Column<string>(type: "varchar(50)", nullable: false),
                    ANO_FABRICAO = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CPF = table.Column<string>(type: "varchar(17)", nullable: false),
                    RG = table.Column<string>(type: "varchar(10)", nullable: false),
                    PRIMEIRO_NOME = table.Column<string>(type: "varchar(25)", nullable: false),
                    ULTIMO_NOME = table.Column<string>(type: "varchar(25)", nullable: false),
                    SEXO = table.Column<int>(type: "int", nullable: false),
                    EmailId = table.Column<Guid>(nullable: true),
                    EnderecoId = table.Column<Guid>(nullable: true),
                    FLAG_ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    TelefoneId = table.Column<Guid>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    CarroId = table.Column<Guid>(nullable: true),
                    AvaliacaoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoa_SGFP_006_EMAIL_EmailId",
                        column: x => x.EmailId,
                        principalTable: "SGFP_006_EMAIL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoa_SGFP_007_ENDERECO_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "SGFP_007_ENDERECO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoa_Telefone_TelefoneId",
                        column: x => x.TelefoneId,
                        principalTable: "Telefone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoa_SGFP_001_AVALIACAO_AvaliacaoId",
                        column: x => x.AvaliacaoId,
                        principalTable: "SGFP_001_AVALIACAO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoa_SGFP_002_CARRO_CarroId",
                        column: x => x.CarroId,
                        principalTable: "SGFP_002_CARRO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estado_PaisId",
                table: "Estado",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_EmailId",
                table: "Pessoa",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_EnderecoId",
                table: "Pessoa",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_TelefoneId",
                table: "Pessoa",
                column: "TelefoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_AvaliacaoId",
                table: "Pessoa",
                column: "AvaliacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_CarroId",
                table: "Pessoa",
                column: "CarroId");

            migrationBuilder.CreateIndex(
                name: "IX_SGFP_002_CARRO_DonoId",
                table: "SGFP_002_CARRO",
                column: "DonoId");

            migrationBuilder.CreateIndex(
                name: "IX_SGFP_003_CIDADE_EstadoId",
                table: "SGFP_003_CIDADE",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_SGFP_007_ENDERECO_CidadeId",
                table: "SGFP_007_ENDERECO",
                column: "CidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SGFP_002_CARRO_Pessoa_DonoId",
                table: "SGFP_002_CARRO",
                column: "DonoId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estado_Pais_PaisId",
                table: "Estado");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_SGFP_006_EMAIL_EmailId",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_SGFP_007_ENDERECO_EnderecoId",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Telefone_TelefoneId",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_SGFP_002_CARRO_CarroId",
                table: "Pessoa");

            migrationBuilder.DropTable(
                name: "SGFP_005_DOCUMENTO");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropTable(
                name: "SGFP_006_EMAIL");

            migrationBuilder.DropTable(
                name: "SGFP_007_ENDERECO");

            migrationBuilder.DropTable(
                name: "SGFP_003_CIDADE");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "SGFP_002_CARRO");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
