using Microsoft.EntityFrameworkCore.Migrations;

namespace travel2gether.Migrations
{
    public partial class Offers_Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Continent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    PicSrc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailsSrc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Continent", "Cost", "Destination", "DetailsSrc", "EndTime", "PicSrc", "ShortDescription", "StartTime" },
                values: new object[] { 1, "Europa", 120000, "Barcelona", " ", "2021.06.18", " ", "", "2021.06.12" });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Continent", "Cost", "Destination", "DetailsSrc", "EndTime", "PicSrc", "ShortDescription", "StartTime" },
                values: new object[] { 2, "Europa", 80000, "Oslo", " ", "2021.11.07", " ", "", "2021.11.01" });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Continent", "Cost", "Destination", "DetailsSrc", "EndTime", "PicSrc", "ShortDescription", "StartTime" },
                values: new object[] { 3, "Europa", 90000, "Edinburgh", " ", "2021.08.25", " ", "", "2021.08.20" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
