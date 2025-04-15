using System.Reflection;
using System.Runtime.Loader;
using CQRSDemo.Client.Components;
using CQRSDemo.Helper.DataAccess;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSingleton<IDemoDataAccess, DemoDataAccess>();
//builder.Services.AddMediatR(
//    configure => configure.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

//var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
//var applicationAssembly = Directory.GetFiles(path, "CQRSDemo.Client.dll").Select(AssemblyLoadContext.Default.LoadFromAssemblyPath).FirstOrDefault();

//builder.Services.AddMediatR(configuration =>
//{
//    configuration.RegisterServicesFromAssembly(applicationAssembly);
//});

builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
