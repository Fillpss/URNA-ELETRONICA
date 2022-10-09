using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Urna.Migrations
{
    public partial class MapeandoForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CandidatoId",
                table: "Voto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Voto_CandidatoId",
                table: "Voto",
                column: "CandidatoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Voto_Candidato_CandidatoId",
                table: "Voto",
                column: "CandidatoId",
                principalTable: "Candidato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voto_Candidato_CandidatoId",
                table: "Voto");

            migrationBuilder.DropIndex(
                name: "IX_Voto_CandidatoId",
                table: "Voto");

            migrationBuilder.DropColumn(
                name: "CandidatoId",
                table: "Voto");
        }
    }
}
