using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ThingsToReturn.Models;

namespace ThingsToReturn.Data
{
    public class ThingsContext : IdentityDbContext
    {
        public ThingsContext(DbContextOptions<ThingsContext> options) : base(options)
        {
        }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Tabela łącząca użytkowników z ofertami
            builder.Entity<AppUserOffer>()
            .HasKey(pg => new { pg.AppUserId, pg.OfferId });

            builder.Entity<AppUserOffer>()
            .HasOne<AppUser>(pg => pg.AppUser)
            .WithMany(p => p.AppUserOffers)
            .HasForeignKey(p => p.AppUserId);

            builder.Entity<AppUserOffer>()
            .HasOne<Offer>(pg => pg.Offer)
            .WithMany(g => g.AppUserOffers)
            .HasForeignKey(g => g.OfferId);

            // Tabela łącząca kategorie z ofertami
            builder.Entity<OfferCategory>()
            .HasKey(pg => new { pg.OfferId, pg.CategoryId });

            builder.Entity<OfferCategory>()
            .HasOne<Offer>(pg => pg.Offer)
            .WithMany(p => p.OfferCategories)
            .HasForeignKey(p => p.OfferId);

            builder.Entity<OfferCategory>()
            .HasOne<Category>(pg => pg.Category)
            .WithMany(g => g.OfferCategories)
            .HasForeignKey(g => g.CategoryId);
        }
    }
}