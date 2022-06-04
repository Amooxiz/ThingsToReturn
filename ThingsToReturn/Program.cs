using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ThingsToReturn;
using ThingsToReturn.Data;
using ThingsToReturn.Models;
//using ThingsToReturn.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ThingsDB");

builder.Services.AddDbContext<ThingsContext>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddIdentity<AppUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ThingsContext>().AddDefaultUI().AddDefaultTokenProviders();


builder.Services.AddRazorPages();
builder.Services.AddProjectService();
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

