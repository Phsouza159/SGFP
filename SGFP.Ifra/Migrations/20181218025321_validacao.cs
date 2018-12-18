using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGFP.Infra.Migrations
{
    public partial class validacao : Migration
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
                    table.PrimaryKey("ID", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SGFP_001_AVALIACAO");
        }
    }
}
