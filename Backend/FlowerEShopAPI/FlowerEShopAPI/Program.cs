using FlowerEShopAPI.BL.Exceptions;
using FlowerEShopAPI.DAL;
using FlowerEShopAPI.Repositories;
using FlowerEShopAPI.Repositories.Helpers;
using FlowerEShopAPI.Repositories.RepositoryInterfaces;
using FlowerEShopAPI.Repositories.RepositoryInterfaces.HelpersInterfaces;
using FlowerEShopAPI.Services;
using FlowerEShopAPI.Services.Helpers;
using FlowerEShopAPI.Services.ServiceInterfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

//DB

builder.Services.AddControllers();
builder.Services.AddDbContext<FlowerShopDBContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

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
builder.Services.AddScoped<IShopService, ShopService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.ConfigureCustomExceptionMiddleware();

app.MapControllers();

app.Run();
