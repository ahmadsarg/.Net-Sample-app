using Microsoft.EntityFrameworkCore;
using SampleApp.BusinessLayer;
using SampleApp.DataAccessLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        options.UseSqlServer(connectionString);
    });

// Add services to the container (equivalent of ConfigureServices in Startup.cs).
builder.Services.AddControllersWithViews();

// Add the database context (replace with your actual connection string).
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add the ProductService to the DI container.
builder.Services.AddScoped<ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline (equivalent of Configure in Startup.cs).
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Products}/{action=Index}/{id?}");

app.Run();
