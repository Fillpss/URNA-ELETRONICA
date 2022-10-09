using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Urna.Migrations
{
    public partial class corrigindoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCandidato",
                table: "Voto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCandidato",
                table: "Voto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
