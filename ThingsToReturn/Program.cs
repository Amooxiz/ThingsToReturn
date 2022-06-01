using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ThingsToReturn.Data;
using ThingsToReturn.Models;
//using ThingsToReturn.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ThingsDB");

builder.Services.AddDbContext<ThingsContext>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddIdentity<AppUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ThingsContext>().AddDefaultUI().AddDefaultTokenProviders();

// Add services to the container.
//builder.Services.AddDbContext<ThingsContext>(options =>
//    options.UseSqlServer(connectionString));
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true);
builder.Services.AddRazorPages();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();


//protected override void OnModelCreating(ModelBuilder builder)
//{
//    base.OnModelCreating(builder);

//    // Tabela ��cz�ca u�ytkownik�w z ofertami
//    builder.Entity<AppUserOffer>()
//    .HasKey(pg => new { pg.AppUserId, pg.OfferId });

//    builder.Entity<AppUserOffer>()
//    .HasOne<AppUser>(pg => pg.AppUser)
//    .WithMany(p => p.AppUserOffers)
//    .HasForeignKey(p => p.AppUserId);

//    builder.Entity<AppUserOffer>()
//    .HasOne<Offer>(pg => pg.Offer)
//    .WithMany(g => g.AppUserOffers)
//    .HasForeignKey(g => g.OfferId);

//    // Tabela ��cz�ca kategorie z ofertami
//    builder.Entity<OfferCategory>()
//    .HasKey(pg => new { pg.OfferId, pg.CategoryId });

//    builder.Entity<OfferCategory>()
//    .HasOne<Offer>(pg => pg.Offer)
//    .WithMany(p => p.OfferCategories)
//    .HasForeignKey(p => p.OfferId);

//    builder.Entity<OfferCategory>()
//    .HasOne<Category>(pg => pg.Category)
//    .WithMany(g => g.OfferCategories)
//    .HasForeignKey(g => g.CategoryId);
//}