using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2023_Kolesov_O_O_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Documents_DocumentId",
                table: "Passengers");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_DocumentId",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "Passengers");

            migrationBuilder.AddColumn<int>(
                name: "PassengerId",
                table: "Documents",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Documents_PassengerId",
                table: "Documents",
                column: "PassengerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Passengers_PassengerId",
                table: "Documents",
                column: "PassengerId",
                principalTable: "Passengers",
                principalColumn: "PassengerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Passengers_PassengerId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_PassengerId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "PassengerId",
                table: "Documents");

            migrationBuilder.AddColumn<int>(
                name: "DocumentId",
                table: "Passengers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_DocumentId",
                table: "Passengers",
                column: "DocumentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Documents_DocumentId",
                table: "Passengers",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "DocumentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
