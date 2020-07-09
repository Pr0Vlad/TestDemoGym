using Microsoft.EntityFrameworkCore.Migrations;

namespace GymLibraryData.Migrations
{
    public partial class Addinitialentitymodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProgramGoal",
                table: "Programs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgramName",
                table: "Programs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProgramId",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExerciseName",
                table: "Exercises",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProgramId",
                table: "Exercises",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "reps",
                table: "Exercises",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sets",
                table: "Exercises",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_People_ProgramId",
                table: "People",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ProgramId",
                table: "Exercises",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Programs_ProgramId",
                table: "Exercises",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Programs_ProgramId",
                table: "People",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Programs_ProgramId",
                table: "Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Programs_ProgramId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_ProgramId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_ProgramId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ProgramGoal",
                table: "Programs");

            migrationBuilder.DropColumn(
                name: "ProgramName",
                table: "Programs");

            migrationBuilder.DropColumn(
                name: "ProgramId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "ExerciseName",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ProgramId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "reps",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "sets",
                table: "Exercises");
        }
    }
}
