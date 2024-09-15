using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeartSite.Migrations.TestDataBaseMigrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentTests_Category_CategoryId",
                table: "CommentTests");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentTests_Person_PersonId",
                table: "CommentTests");

            migrationBuilder.DropIndex(
                name: "IX_CommentTests_CategoryId",
                table: "CommentTests");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CommentTests");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "CommentTests",
                newName: "PersonTestId");

            migrationBuilder.RenameIndex(
                name: "IX_CommentTests_PersonId",
                table: "CommentTests",
                newName: "IX_CommentTests_PersonTestId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentTests_Person_PersonTestId",
                table: "CommentTests",
                column: "PersonTestId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentTests_Person_PersonTestId",
                table: "CommentTests");

            migrationBuilder.RenameColumn(
                name: "PersonTestId",
                table: "CommentTests",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_CommentTests_PersonTestId",
                table: "CommentTests",
                newName: "IX_CommentTests_PersonId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "CommentTests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CommentTests_CategoryId",
                table: "CommentTests",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentTests_Category_CategoryId",
                table: "CommentTests",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentTests_Person_PersonId",
                table: "CommentTests",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
