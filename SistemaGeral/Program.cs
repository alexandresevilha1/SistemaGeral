using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaGeral.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionStr = "server=localhost;userid=alex;password=1234;database=sistemageral";
builder.Services.AddDbContext<SistemaGeralContext>(options =>
    options.UseMySql(connectionStr, ServerVersion.AutoDetect(connectionStr)));

builder.Services.AddScoped<SeedingService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Injeção do SeedingService
app.Services.CreateScope().ServiceProvider.GetRequiredService<SeedingService>().Seed();

var ptBR = new CultureInfo("pt-BR");
var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(ptBR),
    SupportedCultures = new List<CultureInfo> { ptBR },
    SupportedUICultures = new List<CultureInfo> { ptBR },
};

app.UseRequestLocalization(localizationOptions);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
