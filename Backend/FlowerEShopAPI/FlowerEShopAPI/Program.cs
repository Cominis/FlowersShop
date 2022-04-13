using FlowerEShopAPI.DAL;
using FlowerEShopAPI.Repositories;
using FlowerEShopAPI.Repositories.Helpers;
using FlowerEShopAPI.Repositories.RepositoryInterfaces;
using FlowerEShopAPI.Repositories.RepositoryInterfaces.HelpersInterfaces;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

//DB

builder.Services.AddControllers();
builder.Services.AddDbContext<FlowerShopDBContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

// DI
builder.Services.AddScoped<IShopRepository, ShopRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IEnumConverter, EnumConverter>();
builder.Services.AddScoped(provider => new Lazy<IEnumConverter>(provider.GetService<IEnumConverter>));
builder.Services.AddScoped<IShoppingCartRepository, ShopingCartRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IHelpers, Helpers>();
builder.Services.AddScoped(provider => new Lazy<IHelpers>(provider.GetService<IHelpers>));

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
