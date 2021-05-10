using Microsoft.EntityFrameworkCore;
using System;
using travel2gether.Models;

namespace travel2gether.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Offer> Offers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<DomesticOffer> DomesticOffers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region OfferBase
            modelBuilder.Entity<Offer>().HasData(new Offer() { id = 1, continent = "Europa", destination = "Barcelona", startTime = "2021.06.12", endTime = "2021.06.18", cost = 120000, picSrc = "\\assets\\img\\Barcelona.jpg", detailsSrc = "\\assets\\txt\\Barcelona.txt", shortDescription = "Spanyolr riviéra!"});
            modelBuilder.Entity<Offer>().HasData(new Offer() { id = 2, continent = "Europa", destination = "Oslo", startTime = "2021.11.01", endTime = "2021.11.07", cost = 80000, picSrc = "\\assets\\img\\Oslo.jpg", detailsSrc = "\\assets\\txt\\Oslo.txt ", shortDescription = "Lelket melengető pihenés" });
            modelBuilder.Entity<Offer>().HasData(new Offer() { id = 3, continent = "Europa", destination = "Edinburgh", startTime = "2021.08.20", endTime = "2021.08.25", cost = 90000, picSrc = "\\assets\\img\\Edinburgh.jpg", detailsSrc = "\\assets\\txt\\Edinburgh.txt ", shortDescription = "Attól, mert az idő szomorkás, neked nem kell annak lenni!" });
            #endregion

            #region NewsBase
            modelBuilder.Entity<News>().HasData(new News() { Id = 1, Header = "Belgium nyitásra kész!", Body = "\\assets\\news\\body\\1.txt", Hashtag=" karanten", PicSrc = "\\assets\\news\\img\\1.jpg", Date = "2021.04.10"});
            modelBuilder.Entity<News>().HasData(new News() { Id = 2, Header = "Még most érdemes foglalni nyárra", Body = "\\assets\\news\\body\\2.txt", Hashtag = "2021nyar", PicSrc = "\\assets\\news\\img\\2.jpg", Date = "2021.03.21" });
            modelBuilder.Entity<News>().HasData(new News() { Id = 3, Header = "Kicsiny hazánk teljes mértékben támogatja a foci vb-t ", Body = "\\assets\\news\\body\\3.txt", Hashtag = "FociVB", PicSrc = "\\assets\\news\\img\\3.jpg", Date = "2021.04.05" });
            #endregion


            #region DomesticOfferBase
            modelBuilder.Entity<DomesticOffer>().HasData(new DomesticOffer() { Id = 1, Destination = "Salgótarján", StartTime = "2021.06.20", EndTime = "2021.06.22", Cost = 30000, PicSrc = "\\assets\\domestic\\img\\1.jpg", DetailsSrc = "\\assets\\domestic\\txt\\1.txt", ShortDescription = "Kicsiny csoda fenn északon" });
            modelBuilder.Entity<DomesticOffer>().HasData(new DomesticOffer() { Id = 2, Destination = "Hévíz", StartTime = "2021.07.11", EndTime = "2021.07.19", Cost = 10000, PicSrc = "\\assets\\domestic\\img\\2.jpg", DetailsSrc = "\\assets\\domestic\\txt\\2.txt", ShortDescription = "Az idő nem kifogás, itt mindenhogy csodás" });
            modelBuilder.Entity<DomesticOffer>().HasData(new DomesticOffer() { Id = 3, Destination = "Eger", StartTime = "2021.09.20", EndTime = "2021.06.22", Cost = 30000, PicSrc = "\\assets\\domestic\\img\\3.jpg", DetailsSrc = "\\assets\\domestic\\txt\\3.txt", ShortDescription = "Vissza a múltba" });
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=travel2gether");
        }
    }
}
