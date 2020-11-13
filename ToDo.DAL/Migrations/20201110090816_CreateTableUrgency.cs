using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDo.DataAccess.Migrations
{
    public partial class CreateTableUrgency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UrgencyId",
                table: "Assignments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Urgencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urgencies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_UrgencyId",
                table: "Assignments",
                column: "UrgencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Urgencies_UrgencyId",
                table: "Assignments",
                column: "UrgencyId",
                principalTable: "Urgencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Urgencies_UrgencyId",
                table: "Assignments");

            migrationBuilder.DropTable(
                name: "Urgencies");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_UrgencyId",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "UrgencyId",
                table: "Assignments");
        }
    }
}
