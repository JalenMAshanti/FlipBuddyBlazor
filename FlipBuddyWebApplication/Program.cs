using Blazored.LocalStorage;
using FlipBuddyWebApplication.Client.ViewModels.AddToInventory;
using FlipBuddyWebApplication.Client.ViewModels.Home;
using FlipBuddyWebApplication.Client.ViewModels.Home.DonutChart;
using FlipBuddyWebApplication.Client.ViewModels.Inventory;
using FlipBuddyWebApplication.Client.ViewModels.Inventory.ItemDisplay;
using FlipBuddyWebApplication.Client.ViewModels.Search;
using FlipBuddyWebApplication.Client.ViewModels.TopCategories;
using FlipBuddyWebApplication.Components;
using FlipBuddyWebApplication.Domain.Constants;
using FlipBuddyWebApplication.Persistence.API;
using FlipBuddyWebApplication.Persistence.Factories;
using FlipBuddyWebApplication.Persistence.Repositories;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);


var configuration = builder.Configuration;

var baseurl = configuration["Database:baseurl"];
Hidden.baseApiUrl = baseurl;

// Add services to the container.
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents()
	.AddInteractiveWebAssemblyComponents();

builder.Services.AddBlazoredLocalStorage();

//Services
builder.Services.AddMudServices();
builder.Services.AddTransient<HttpClient>();
builder.Services.AddTransient<ExternalApiService>();
builder.Services.AddTransient<ClientFactory>();
builder.Services.AddSingleton<GoogleAuthService>();
//Repositories
builder.Services.AddTransient<UserRepository>();
builder.Services.AddTransient<ProductRepository>();
builder.Services.AddTransient<CategoryRepository>();
builder.Services.AddTransient<GuidRepository>();
builder.Services.AddTransient<LoginRepository>();
builder.Services.AddTransient<ConditionRepository>();
builder.Services.AddTransient<EbayRepository>();
//Clients
builder.Services.AddTransient<HomeViewModelClient>();
builder.Services.AddTransient<SearchViewModelClient>();
builder.Services.AddTransient<AddToInventoryViewModelClient>();
builder.Services.AddTransient<DonutChartViewModelClient>();
builder.Services.AddTransient<TopCategoriesClient>();
builder.Services.AddTransient<InventoryClient>();
builder.Services.AddTransient<ItemDisplayClient>();
//ViewModels
builder.Services.AddSingleton<HomeViewModel>();
builder.Services.AddSingleton<SearchViewModel>();
builder.Services.AddSingleton<AddToInventoryViewModel>();
builder.Services.AddSingleton<DonutChartViewModel>();
builder.Services.AddSingleton<TopCategoriesViewModel>();
builder.Services.AddSingleton<InventoryViewModel>();
builder.Services.AddSingleton<ItemDisplayViewModel>();


builder.Services.AddServerSideBlazor()
	   .AddCircuitOptions(options => { options.DetailedErrors = true; });

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


app.UseAuthorization();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode()
	.AddInteractiveWebAssemblyRenderMode()
	.AddAdditionalAssemblies(typeof(FlipBuddyWebApplication.Client._Imports).Assembly);




app.Run();
