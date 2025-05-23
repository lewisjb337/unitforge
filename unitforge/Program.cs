using Sidio.Sitemap.AspNetCore;
using Sidio.Sitemap.Blazor;
using Sidio.Sitemap.Core.Services;
using unitforge.Components;
using unitforge.Services;
using unitforge.Services.Abstractions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAngleConversionService, AngleConversionService>();
builder.Services.AddScoped<IAreaConversionService, AreaConversionService>();
builder.Services.AddScoped<IDataStorageConversionService, DataStorageConversionService>();
builder.Services.AddScoped<IEnergyConversionService, EnergyConversionService>();
builder.Services.AddScoped<IForceConversionService, ForceConversionService>();
builder.Services.AddScoped<IFuelConsumptionConversionService, FuelConsumptionConversionService>();
builder.Services.AddScoped<ILengthConversionService, LengthConversionService>();
builder.Services.AddScoped<IPowerConversionService, PowerConversionService>();
builder.Services.AddScoped<IPressureConversionService, PressureConversionService>();
builder.Services.AddScoped<ISpeedConversionService, SpeedConversionService>();
builder.Services.AddScoped<ITemperatureConversionService, TemperatureConversionService>();
builder.Services.AddScoped<IAreaConversionService, AreaConversionService>();
builder.Services.AddScoped<ITimeConversionService, TimeConversionService>();
builder.Services.AddScoped<IVolumeConversionService, VolumeConversionService>();
builder.Services.AddScoped<IWeightConversionService, WeightConversionService>();

builder.Services
    .AddHttpContextAccessor()
    .AddDefaultSitemapServices<HttpContextBaseUrlProvider>();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseSitemap();

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();