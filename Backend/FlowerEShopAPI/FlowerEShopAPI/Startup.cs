using FlowerEShopAPI.BL.Exceptions;
using FlowerEShopAPI.BL.Middlewares;
using FlowerEShopAPI.BL.Services;
using FlowerEShopAPI.BL.Services.Helpers;
using FlowerEShopAPI.BL.Services.ServiceInterfaces;
using FlowerEShopAPI.DAL;
using FlowerEShopAPI.DAL.Repositories;
using FlowerEShopAPI.DAL.Repositories.Helpers;
using FlowerEShopAPI.DAL.Repositories.RepositoryInterfaces;
using FlowerEShopAPI.DAL.Repositories.RepositoryInterfaces.HelpersInterfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace FlowerEShopAPI
{
    public class Startup
    {
        private string MyAllowSpecificOrigins = "my_allow_specific_origins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //DB
            services.AddControllers();
            services.AddDbContext<FlowerShopDBContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = Configuration["Jwt:Audience"],
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });

            services.AddControllersWithViews()
             .AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            // DI
            //Repos
            services.AddScoped<IShopRepository, ShopRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IEnumConverter, EnumConverter>();
            services.AddScoped(provider => new Lazy<IEnumConverter>(provider.GetService<IEnumConverter>));
            services.AddScoped<IShoppingCartRepository, ShopingCartRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ILogsRepository, LogsRepository>();
            services.AddScoped<IHelpers, Helpers>();
            services.AddScoped(provider => new Lazy<IHelpers>(provider.GetService<IHelpers>));

            //Services
            services.AddScoped<IValidation, Validation>();
            services.AddScoped(provider => new Lazy<IValidation>(provider.GetService<IValidation>));
            services.AddScoped<IShopService, ShopService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IShoppingCartService, ShoppingCartService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ISearchService, SearchService>();
            services.AddScoped<ILogsService, LogsService>();

            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  policy =>
                                  {
                                      policy.WithOrigins("*")
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod();
                                  });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseMiddleware<JwtMiddleware>();

            app.ConfigureCustomExceptionMiddleware();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}