using Microsoft.EntityFrameworkCore.Migrations;

namespace travel2gether.Migrations
{
    public partial class NewsAndDomesticOfferBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DomesticOffers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(nullable: true),
                    StartTime = table.Column<string>(nullable: true),
                    EndTime = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    PicSrc = table.Column<string>(nullable: true),
                    DetailsSrc = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomesticOffers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Hashtag = table.Column<string>(nullable: true),
                    PicSrc = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DomesticOffers",
                columns: new[] { "Id", "Cost", "Destination", "DetailsSrc", "EndTime", "PicSrc", "ShortDescription", "StartTime" },
                values: new object[,]
                {
                    { 1, 30000, "Salgótarján", "\\assets\\domestic\\txt\\1", "2021.06.22", "\\assets\\domestic\\img\\1", "Kicsiny csoda fenn északon", "2021.06.20" },
                    { 2, 10000, "Hévíz", "\\assets\\domestic\\txt\\2", "2021.07.19", "\\assets\\domestic\\img\\2", "Az idő nem kifogás, itt mindenhogy csodás", "2021.07.11" },
                    { 3, 30000, "Eger", "\\assets\\domestic\\txt\\3", "2021.06.22", "\\assets\\domestic\\img\\3", "Vissza a múltba", "2021.09.20" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Body", "Date", "Hashtag", "Header", "PicSrc" },
                values: new object[,]
                {
                    { 1, "\\assets\\news\\body\\1", "2021.04.10", " karanten", "Belgium nyitásra kész!", "\\assets\\news\\img\\1" },
                    { 2, "\\assets\\news\\body\\2", "2021.03.21", "2021nyar", "Még most érdemes foglalni nyárra", "\\assets\\news\\img\\2" },
                    { 3, "\\assets\\news\\body\\3", "2021.04.05", "FociVB", "Kicsiny hazánk teljes mértékben támogatja a foci vb-t ", "\\assets\\news\\img\\3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DomesticOffers");

            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
