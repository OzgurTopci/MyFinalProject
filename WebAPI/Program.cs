using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstarct;
using Business.Concrete;
using Business.DependencyReslovers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Autofac, Ninject, CastleWindsor, StructreMap, Light›nject, Dry›nject
//AOP
//builder.Services.AddSingleton<IProductService, ProductManager>();
//builder.Services.AddSingleton<IProductDal, EfProductDal>();
//builder.Services.AddDbContext<DbContext>(options =>  options.UseSqlServer(,  sqlServerOptions => sqlServerOptions.EnableRetryOnFailure()));

//Kendi olu˛turdugumuz Autofacle konfigure etme yeri
builder.Host.UseServiceProviderFactory(services => new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder => { builder.RegisterModule(new AuotfacBusinessModule()); });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
