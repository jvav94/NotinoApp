using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotinoAppka.Migrations
{
    /// <inheritdoc />
    public partial class MyFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotinoData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotinoData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataFiles",
                columns: table => new
                {
                    DataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    some = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    optional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotinoModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataFiles", x => x.DataId);
                    table.ForeignKey(
                        name: "FK_DataFiles_NotinoData_NotinoModelId",
                        column: x => x.NotinoModelId,
                        principalTable: "NotinoData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataFiles_NotinoModelId",
                table: "DataFiles",
                column: "NotinoModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataFiles");

            migrationBuilder.DropTable(
                name: "NotinoData");
        }
    }
}
