using Microsoft.EntityFrameworkCore.Migrations;

namespace LabcoreDay2.Migrations
{
    public partial class mod1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Students_stude_id",
                table: "Projects");

            migrationBuilder.AlterColumn<int>(
                name: "stude_id",
                table: "Projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Students_stude_id",
                table: "Projects",
                column: "stude_id",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Students_stude_id",
                table: "Projects");

            migrationBuilder.AlterColumn<int>(
                name: "stude_id",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Students_stude_id",
                table: "Projects",
                column: "stude_id",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
