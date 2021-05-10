using Microsoft.EntityFrameworkCore.Migrations;

namespace travel2gether.Migrations
{
    public partial class jpgtextEnin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DomesticOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DetailsSrc", "PicSrc" },
                values: new object[] { "\\assets\\domestic\\txt\\1.txt", "\\assets\\domestic\\img\\1.jpg" });

            migrationBuilder.UpdateData(
                table: "DomesticOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DetailsSrc", "PicSrc" },
                values: new object[] { "\\assets\\domestic\\txt\\2.txt", "\\assets\\domestic\\img\\2.jpg" });

            migrationBuilder.UpdateData(
                table: "DomesticOffers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DetailsSrc", "PicSrc" },
                values: new object[] { "\\assets\\domestic\\txt\\3.txt", "\\assets\\domestic\\img\\3.jpg" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "PicSrc" },
                values: new object[] { "\\assets\\news\\body\\1.txt", "\\assets\\news\\img\\1.jpg" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "PicSrc" },
                values: new object[] { "\\assets\\news\\body\\2.txt", "\\assets\\news\\img\\2.jpg" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "PicSrc" },
                values: new object[] { "\\assets\\news\\body\\3.txt", "\\assets\\news\\img\\3.jpg" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DetailsSrc", "PicSrc" },
                values: new object[] { "\\assets\\txt\\Barcelona.txt", "\\assets\\img\\Barcelona.jpg" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DetailsSrc", "PicSrc" },
                values: new object[] { "\\assets\\txt\\Oslo.txt ", "\\assets\\img\\Oslo.jpg" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DetailsSrc", "PicSrc" },
                values: new object[] { "\\assets\\txt\\Edinburgh.txt ", "\\assets\\img\\Edinburgh.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DomesticOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DetailsSrc", "PicSrc" },
                values: new object[] { "\\assets\\domestic\\txt\\1", "\\assets\\domestic\\img\\1" });

            migrationBuilder.UpdateData(
                table: "DomesticOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DetailsSrc", "PicSrc" },
                values: new object[] { "\\assets\\domestic\\txt\\2", "\\assets\\domestic\\img\\2" });

            migrationBuilder.UpdateData(
                table: "DomesticOffers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DetailsSrc", "PicSrc" },
                values: new object[] { "\\assets\\domestic\\txt\\3", "\\assets\\domestic\\img\\3" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "PicSrc" },
                values: new object[] { "\\assets\\news\\body\\1", "\\assets\\news\\img\\1" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "PicSrc" },
                values: new object[] { "\\assets\\news\\body\\2", "\\assets\\news\\img\\2" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "PicSrc" },
                values: new object[] { "\\assets\\news\\body\\3", "\\assets\\news\\img\\3" });

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
    }
}
