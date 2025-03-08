using unitforge.Components;
using unitforge.Services;
using unitforge.Services.Abstractions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAreaConversionService, AreaConversionService>();
builder.Services.AddScoped<ILengthConversionService, LengthConversionService>();
builder.Services.AddScoped<ITemperatureConversionService, TemperatureConversionService>();
builder.Services.AddScoped<IAreaConversionService, AreaConversionService>();
builder.Services.AddScoped<ITimeConversionService, TimeConversionService>();
builder.Services.AddScoped<IVolumeConversionService, VolumeConversionService>();
builder.Services.AddScoped<IWeightConversionService, WeightConversionService>();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();