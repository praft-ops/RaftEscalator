
//    <Raft Escalator: A program for escalating issues.>
//    Copyright (C) <2024>  <Patrick Sullivan Raftery>

//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU Affero General Public License as published
//   by the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.

//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU Affero General Public License for more details.

//    You should have received a copy of the GNU Affero General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
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

//Use HttpsRedirection();
app.UseHttpsRedirection();

//Use Routing
app.UseRouting();

//Use Authorization
app.UseAuthorization();

//Add Enpoints for Razor Pages
app.MapRazorPages();

//Add Map Controllers for Attribute Routing
app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//Run the App
app.Run();
