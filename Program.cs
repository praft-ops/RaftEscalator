using AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RaftEscalator.Data;
// Create the bulder using .CreateBuilder
var builder = WebApplication.CreateBuilder(args);

// Add Dependency Injection to the DI Container

// Add the Razor Pages Service
builder.Services.AddRazorPages();

// Add Service for SQL DB for CRUD Operations
builder.Services.AddDbContext<RaftEscalatorContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("RaftEscalatorContext") ?? throw new InvalidOperationException("Connection string 'RaftEscalatorContext' not found.")));

// Add the Controllers with Views Service
builder.Services.AddControllersWithViews();

//Add Routing Service
builder.Services.AddRouting();

// Build the application with the Builder
var app = builder.Build();

//Configure HTTPS Middleware Pipeline Functionaility
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

//Use Authentication
app.UseAuthentication();

//Use Authorization
app.UseAuthorization();

//Add Enpoints for Razor Pages
app.MapRazorPages();

//Add Map Controllers for Attribute Routing
app.MapControllers();

//Run the App
app.Run();
