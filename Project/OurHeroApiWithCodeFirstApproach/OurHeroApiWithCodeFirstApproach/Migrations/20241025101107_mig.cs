using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OurHeroApiWithCodeFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblOurHeros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOurHeros", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "tblOurHeros",
                columns: new[] { "Id", "FirstName", "LastName", "isActive" },
                values: new object[] { 1, "System", "", true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblOurHeros");
        }
    }
}
