using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDevOps.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TodoItem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItem", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Description", "IsComplete", "Name" },
                values: new object[] { 1L, "In Meeting need to discuss some points.", true, "Meeting with management" });

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Description", "IsComplete", "Name" },
                values: new object[] { 2L, "List of this this item buy.", false, "Go for shooping" });

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Description", "IsComplete", "Name" },
                values: new object[] { 3L, "Here is task to ask to do on call.", true, "Call to some one for do some task" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoItem");
        }
    }
}
