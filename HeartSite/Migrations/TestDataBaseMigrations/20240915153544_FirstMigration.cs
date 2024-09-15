using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeartSite.Migrations.TestDataBaseMigrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommentTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextTest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonTestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentTests_PersonTests_PersonTestId",
                        column: x => x.PersonTestId,
                        principalTable: "PersonTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentTests_PersonTestId",
                table: "CommentTests",
                column: "PersonTestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentTests");

            migrationBuilder.DropTable(
                name: "PersonTests");
        }
    }
}
