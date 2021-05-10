using Microsoft.EntityFrameworkCore.Migrations;

namespace travel2gether.Migrations
{
    public partial class offerdisc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DetailsSrc", "PicSrc", "ShortDescription" },
                values: new object[] { "C:\\Users\\ASUS\\Angular\\travel2gether\\travel2gether\\travel2gether\\ClientApp\\src\\assets\\txt\\Barcelona", "C:\\Users\\ASUS\\Angular\\travel2gether\\travel2gether\\travel2gether\\ClientApp\\src\\assets\\img\\Barcelona", "Spanyolr riviéra!" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DetailsSrc", "PicSrc", "ShortDescription" },
                values: new object[] { "C:\\Users\\ASUS\\Angular\\travel2gether\\travel2gether\\travel2gether\\ClientApp\\src\\assets\\txt\\Oslo ", "C:\\Users\\ASUS\\Angular\\travel2gether\\travel2gether\\travel2gether\\ClientApp\\src\\assets\\img\\Oslo", "Lelket melengető pihenés" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DetailsSrc", "PicSrc", "ShortDescription" },
                values: new object[] { "C:\\Users\\ASUS\\Angular\\travel2gether\\travel2gether\\travel2gether\\ClientApp\\src\\assets\\txt\\Edinburgh ", "C:\\Users\\ASUS\\Angular\\travel2gether\\travel2gether\\travel2gether\\ClientApp\\src\\assets\\img\\Edinburgh", "Attól, mert az idő szomorkás, neked nem kell annak lenni!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DetailsSrc", "PicSrc", "ShortDescription" },
                values: new object[] { " ", " ", "" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DetailsSrc", "PicSrc", "ShortDescription" },
                values: new object[] { " ", " ", "" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DetailsSrc", "PicSrc", "ShortDescription" },
                values: new object[] { " ", " ", "" });
        }
    }
}
