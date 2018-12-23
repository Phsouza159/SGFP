using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGFP.Infra.Migrations
{
    public partial class mapCompleto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SGFP_001_AVALIACAO",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NOTA = table.Column<int>(type: "int", nullable: false),
                    TEXTO = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SGFP_001_AVALIACAO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SGFP_005_DOCUMENTO",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SGFP_005_DOCUMENTO", x => x.Id);
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
                    table.PrimaryKey("PK_SGFP_006_EMAIL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SGFP_010_MAO_DE_OBRA",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TIPO_MAO_OBRA = table.Column<string>(type: "varchar(25)", nullable: false),
                    NOME = table.Column<string>(type: "varchar(25)", nullable: false),
                    VALOR = table.Column<double>(type: "float", nullable: true),
                    JORNADA_TRABALHO = table.Column<double>(type: "float", nullable: true),
                    VALOR_HORA_EXTRA = table.Column<double>(type: "float", nullable: true),
                    LIMITE_HORA_EXTRA = table.Column<double>(type: "float", nullable: true),
                    FLAG_ATIVO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_010", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SGFP_012_PAIS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SIGLA = table.Column<string>(type: "char(3)", nullable: false),
                    NOME = table.Column<string>(type: "varchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_012", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SGFP_013_SERVICO",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NOME_SERVICO = table.Column<string>(type: "varchar(35)", nullable: false),
                    VALOR = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_013", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SGFP_014_TELEFONE",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DDD = table.Column<string>(type: "char(3)", nullable: false),
                    NUMERO = table.Column<string>(type: "char(10)", nullable: false),
                    TIPO_TELEFONE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_014", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SGFP_008_ESTADO",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SIGLA = table.Column<string>(type: "char(2)", nullable: false),
                    NOME = table.Column<string>(type: "varchar(15)", nullable: false),
                    PaisId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_008", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SGFP_008_ESTADO_SGFP_012_PAIS_PaisId",
                        column: x => x.PaisId,
                        principalTable: "SGFP_012_PAIS",
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
                    table.PrimaryKey("PK_SGFP_003_CIDADE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SGFP_003_CIDADE_SGFP_008_ESTADO_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "SGFP_008_ESTADO",
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
                    table.PrimaryKey("PK_SGFP_007_ENDERECO", x => x.Id);
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
                    table.PrimaryKey("PK_SGFP_002_CARRO", x => x.Id);
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
                    AvaliacaoId = table.Column<Guid>(nullable: true),
                    CATEGORIA = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_Pessoa_SGFP_014_TELEFONE_TelefoneId",
                        column: x => x.TelefoneId,
                        principalTable: "SGFP_014_TELEFONE",
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

            migrationBuilder.CreateTable(
                name: "SGFP_011_ORCAMENTO",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ClienteId = table.Column<Guid>(nullable: true),
                    CarroId = table.Column<Guid>(nullable: true),
                    ServicoId = table.Column<Guid>(nullable: true),
                    LISTA_ORCAMENTO = table.Column<string>(type: "varchar(255)", nullable: true),
                    DocumentoId = table.Column<Guid>(nullable: true),
                    ENTRADA = table.Column<DateTime>(type: "datetime", nullable: false),
                    ENTREGA = table.Column<DateTime>(type: "datetime", nullable: false),
                    VALOR_ORCAMENTO = table.Column<double>(type: "float", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_011", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SGFP_011_ORCAMENTO_SGFP_002_CARRO_CarroId",
                        column: x => x.CarroId,
                        principalTable: "SGFP_002_CARRO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SGFP_011_ORCAMENTO_Pessoa_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SGFP_011_ORCAMENTO_SGFP_005_DOCUMENTO_DocumentoId",
                        column: x => x.DocumentoId,
                        principalTable: "SGFP_005_DOCUMENTO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SGFP_011_ORCAMENTO_SGFP_013_SERVICO_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "SGFP_013_SERVICO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "PK_004",
                table: "Pessoa",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "PK_009",
                table: "Pessoa",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "PK_001",
                table: "SGFP_001_AVALIACAO",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SGFP_002_CARRO_DonoId",
                table: "SGFP_002_CARRO",
                column: "DonoId");

            migrationBuilder.CreateIndex(
                name: "PK_002",
                table: "SGFP_002_CARRO",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SGFP_003_CIDADE_EstadoId",
                table: "SGFP_003_CIDADE",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "PK_003",
                table: "SGFP_003_CIDADE",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "PK_006",
                table: "SGFP_006_EMAIL",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SGFP_007_ENDERECO_CidadeId",
                table: "SGFP_007_ENDERECO",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "PK_007",
                table: "SGFP_007_ENDERECO",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SGFP_008_ESTADO_PaisId",
                table: "SGFP_008_ESTADO",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_SGFP_011_ORCAMENTO_CarroId",
                table: "SGFP_011_ORCAMENTO",
                column: "CarroId");

            migrationBuilder.CreateIndex(
                name: "IX_SGFP_011_ORCAMENTO_ClienteId",
                table: "SGFP_011_ORCAMENTO",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_SGFP_011_ORCAMENTO_DocumentoId",
                table: "SGFP_011_ORCAMENTO",
                column: "DocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_SGFP_011_ORCAMENTO_ServicoId",
                table: "SGFP_011_ORCAMENTO",
                column: "ServicoId");

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
                name: "FK_Pessoa_SGFP_006_EMAIL_EmailId",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_SGFP_007_ENDERECO_EnderecoId",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_SGFP_014_TELEFONE_TelefoneId",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_SGFP_001_AVALIACAO_AvaliacaoId",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_SGFP_002_CARRO_CarroId",
                table: "Pessoa");

            migrationBuilder.DropTable(
                name: "SGFP_010_MAO_DE_OBRA");

            migrationBuilder.DropTable(
                name: "SGFP_011_ORCAMENTO");

            migrationBuilder.DropTable(
                name: "SGFP_005_DOCUMENTO");

            migrationBuilder.DropTable(
                name: "SGFP_013_SERVICO");

            migrationBuilder.DropTable(
                name: "SGFP_006_EMAIL");

            migrationBuilder.DropTable(
                name: "SGFP_007_ENDERECO");

            migrationBuilder.DropTable(
                name: "SGFP_003_CIDADE");

            migrationBuilder.DropTable(
                name: "SGFP_008_ESTADO");

            migrationBuilder.DropTable(
                name: "SGFP_012_PAIS");

            migrationBuilder.DropTable(
                name: "SGFP_014_TELEFONE");

            migrationBuilder.DropTable(
                name: "SGFP_001_AVALIACAO");

            migrationBuilder.DropTable(
                name: "SGFP_002_CARRO");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
