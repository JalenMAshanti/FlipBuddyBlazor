using FlipBuddyWebApplication.Components;
using FlipBuddyWebApplication.Persistence.API;
using FlipBuddyWebApplication.Persistence.Factories;
using FlipBuddyWebApplication.Persistence.Repositories;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

//Services
builder.Services.AddMudServices();
builder.Services.AddTransient<HttpClient>();
builder.Services.AddTransient<ExternalApiService>();
builder.Services.AddTransient<ClientFactory>();

//Repositories
builder.Services.AddTransient<UserRepository>();
builder.Services.AddTransient<ProductRepository>();
builder.Services.AddTransient<CategoryRepository>();
builder.Services.AddTransient<GuidRepository>();
builder.Services.AddTransient<LoginRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(FlipBuddyWebApplication.Client._Imports).Assembly);

app.Run();
