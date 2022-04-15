using FlowerEShopAPI.DAL;
using FlowerEShopAPI.Repositories;
using FlowerEShopAPI.Repositories.Helpers;
using FlowerEShopAPI.Repositories.RepositoryInterfaces;
using FlowerEShopAPI.Repositories.RepositoryInterfaces.HelpersInterfaces;
using FlowerEShopAPI.Services.Helpers;
using FlowerEShopAPI.Services.ServiceInterfaces;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

//DB

builder.Services.AddControllers();
builder.Services.AddDbContext<FlowerShopDBContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// DI
//Repos
builder.Services.AddScoped<IShopRepository, ShopRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IEnumConverter, EnumConverter>();
builder.Services.AddScoped(provider => new Lazy<IEnumConverter>(provider.GetService<IEnumConverter>));
builder.Services.AddScoped<IShoppingCartRepository, ShopingCartRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IHelpers, Helpers>();
builder.Services.AddScoped(provider => new Lazy<IHelpers>(provider.GetService<IHelpers>));

//Services
builder.Services.AddScoped<IValidation, Validation>();
builder.Services.AddScoped(provider => new Lazy<IValidation>(provider.GetService<IValidation>));

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
