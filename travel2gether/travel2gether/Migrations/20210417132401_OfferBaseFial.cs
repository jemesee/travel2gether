using Microsoft.EntityFrameworkCore.Migrations;

namespace travel2gether.Migrations
{
    public partial class OfferBaseFial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DetailsSrc", "PicSrc" },
                values: new object[] { "\\assets\\txt\\Barcelona", "\\assets\\img\\Barcelona" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DetailsSrc", "PicSrc" },
                values: new object[] { "\\assets\\txt\\Oslo ", "\\assets\\img\\Oslo" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DetailsSrc", "PicSrc" },
                values: new object[] { "\\assets\\txt\\Edinburgh ", "\\assets\\img\\Edinburgh" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DetailsSrc", "PicSrc" },
                values: new object[] { "C:\\Users\\ASUS\\Angular\\travel2gether\\travel2gether\\travel2gether\\ClientApp\\src\\assets\\txt\\Barcelona", "C:\\Users\\ASUS\\Angular\\travel2gether\\travel2gether\\travel2gether\\ClientApp\\src\\assets\\img\\Barcelona" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DetailsSrc", "PicSrc" },
                values: new object[] { "C:\\Users\\ASUS\\Angular\\travel2gether\\travel2gether\\travel2gether\\ClientApp\\src\\assets\\txt\\Oslo ", "C:\\Users\\ASUS\\Angular\\travel2gether\\travel2gether\\travel2gether\\ClientApp\\src\\assets\\img\\Oslo" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DetailsSrc", "PicSrc" },
                values: new object[] { "C:\\Users\\ASUS\\Angular\\travel2gether\\travel2gether\\travel2gether\\ClientApp\\src\\assets\\txt\\Edinburgh ", "C:\\Users\\ASUS\\Angular\\travel2gether\\travel2gether\\travel2gether\\ClientApp\\src\\assets\\img\\Edinburgh" });
        }
    }
}
