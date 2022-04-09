using FlowerEShopAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ProductContext>(opt =>
    opt.UseInMemoryDatabase("ProductList"));
builder.Services.AddDbContext<ShopContext>(opt =>
    opt.UseInMemoryDatabase("ProductList"));
builder.Services.AddDbContext<ShoppingCartContext>(opt =>
    opt.UseInMemoryDatabase("ProductList"));

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
