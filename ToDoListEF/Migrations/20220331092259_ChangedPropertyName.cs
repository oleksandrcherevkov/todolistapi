using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoListEF.Migrations
{
    public partial class ChangedPropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "ToDoBlocks",
                newName: "Text");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "ToDoBlocks",
                newName: "Content");
        }
    }
}
