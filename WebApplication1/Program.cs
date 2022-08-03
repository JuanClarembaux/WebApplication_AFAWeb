using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<DealershipContext>();

var app = builder.Build();

//IConfiguration Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

//var options = new DbContextOptionsBuilder<DealershipContext>().UseSqlServer(Configuration.GetConnectionString("DevPlaceConnection")).Options;

//using var db = new DealershipContext(options);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
