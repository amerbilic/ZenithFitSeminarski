using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.WebAPI.Filters;
using ZenithFit.WebAPI.Services;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;
using Microsoft.AspNetCore.Authentication;
using ZenithFit.WebAPI.Security;
using Microsoft.OpenApi.Models;

namespace ZenithFit.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddControllers(x=> x.Filters.Add<ErrorFilter>());
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ZenithFit API V1", Version = "v1" });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });

            });
            var connection = Configuration.GetConnectionString("ZenithFit");

            services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IRolesService, RolesService>();
            //Articles
            services.AddScoped<IArticlesService, ArticlesService>();
            //Manufacturers
            services.AddScoped<ICRUDService<Model.Manufacturers, object, ManufacturersInsertRequest, object>, ManufacturersService>();
            //Categories
            services.AddScoped<ICRUDService<Model.Categories, object, CategoriesInsertRequest, object>, CategoriesService>();
            //Suppliers
            services.AddScoped<ICRUDService<Model.Suppliers, SuppliersSearchRequest, SuppliersUpsertRequest, SuppliersUpsertRequest>, SuppliersService>();
            //Clients
            services.AddScoped<IClientService, ClientService>();
            //Ratings
            services.AddScoped<ICRUDService<Model.Ratings, object, RatingsInsertRequest, object>, RatingsService>();
            //Orders
            services.AddScoped<ICRUDService<Model.Orders, OrdersSearchRequest, OrdersInsertRequest, object>, OrdersService>();
            //OrderDetails
            services.AddScoped<ICRUDService<Model.OrderDetails, object, OrderDetailsInsertRequest, object>, OrderDetailsService>();
            //CompleteOrder
            services.AddScoped<ICRUDService<Model.CompleteOrder, object, CompleteOrderInsertRequest, CompleteOrderUpdateRequest>, CompleteOrderService>();
            //Procurements
            services.AddScoped<ICRUDService<Model.Procurements, ProcurementsSearchRequest, ProcurementsInsertRequest, object>, ProcurementsService>();
            //ProcurementDetails
            services.AddScoped<ICRUDService<Model.ProcurementDetails, object, ProcurementDetailsInsertRequest, object>, ProcurementDetailsService>();
            //Warehouses
            services.AddScoped<ICRUDService<Model.Warehouses, WarehousesSearchRequest, WarehousesInsertRequest, object>, WarehousesService>();
            //Messages
            services.AddScoped<IMessagesService, MessagesService>();
            services.AddScoped<IRecommender, RecommenderService>();
            services.AddScoped<ICRUDService<Model.GoalsChoices,object,object,object>, GoalsService>();
            services.AddScoped<ICRUDService<Model.Comments,CommentsSearchRequest,CommentsInsertRequest,object>,CommentsService>();
            //Context
            services.AddScoped<IService<Model.Roles, object>, BaseService<Model.Roles,object,Database.Roles>>();
            services.AddDbContext<ZenithFitDatabaseContext>(options => options.UseSqlServer(connection));
            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseAuthentication();


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

           // app.UseHttpsRedirection();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ZenithFit API V1");
            });

            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
