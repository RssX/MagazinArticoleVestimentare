using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagazinArticoleVestimentare.Migrations
{
    /// <inheritdoc />
    public partial class schimbarenumefkClientiId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comanda_Clienti_ClientIdFK",
                table: "Comanda");

            migrationBuilder.DropIndex(
                name: "IX_Comanda_ClientIdFK",
                table: "Comanda");

            migrationBuilder.DropColumn(
                name: "ClientIdFK",
                table: "Comanda");

            migrationBuilder.CreateIndex(
                name: "IX_Comanda_ClientId",
                table: "Comanda",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comanda_Clienti_ClientId",
                table: "Comanda",
                column: "ClientId",
                principalTable: "Clienti",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comanda_Clienti_ClientId",
                table: "Comanda");

            migrationBuilder.DropIndex(
                name: "IX_Comanda_ClientId",
                table: "Comanda");

            migrationBuilder.AddColumn<int>(
                name: "ClientIdFK",
                table: "Comanda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comanda_ClientIdFK",
                table: "Comanda",
                column: "ClientIdFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Comanda_Clienti_ClientIdFK",
                table: "Comanda",
                column: "ClientIdFK",
                principalTable: "Clienti",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
