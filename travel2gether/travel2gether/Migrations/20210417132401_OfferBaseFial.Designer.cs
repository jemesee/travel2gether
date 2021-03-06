// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using travel2gether.Data;

namespace travel2gether.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210417132401_OfferBaseFial")]
    partial class OfferBaseFial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("travel2gether.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Continent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DetailsSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Offers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Continent = "Europa",
                            Cost = 120000,
                            Destination = "Barcelona",
                            DetailsSrc = "\\assets\\txt\\Barcelona",
                            EndTime = "2021.06.18",
                            PicSrc = "\\assets\\img\\Barcelona",
                            ShortDescription = "Spanyolr riviéra!",
                            StartTime = "2021.06.12"
                        },
                        new
                        {
                            Id = 2,
                            Continent = "Europa",
                            Cost = 80000,
                            Destination = "Oslo",
                            DetailsSrc = "\\assets\\txt\\Oslo ",
                            EndTime = "2021.11.07",
                            PicSrc = "\\assets\\img\\Oslo",
                            ShortDescription = "Lelket melengető pihenés",
                            StartTime = "2021.11.01"
                        },
                        new
                        {
                            Id = 3,
                            Continent = "Europa",
                            Cost = 90000,
                            Destination = "Edinburgh",
                            DetailsSrc = "\\assets\\txt\\Edinburgh ",
                            EndTime = "2021.08.25",
                            PicSrc = "\\assets\\img\\Edinburgh",
                            ShortDescription = "Attól, mert az idő szomorkás, neked nem kell annak lenni!",
                            StartTime = "2021.08.20"
                        });
                });

            modelBuilder.Entity("travel2gether.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
