
//instantiate your logger and where you want to log to
using DoctorWho.Db;
using DoctorWho.Db.Interfaces;
using DoctorWho.Db.Repositories;
using DoctorWho.Db.Validators;
using DoctorWho.Web.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/DoctorWho.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

//tells system to use serilog instead of logger
builder.Host.UseSerilog();

//Add services to the container.
builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson()
    .AddXmlDataContractSerializerFormatters();//Adds xml inout and output formatters to api

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//allows us to inject a content type provider in other parts of our code
builder.Services.AddSingleton<FileExtensionContentTypeProvider>();

//Because AddFluentValidator is depracated
builder.Services.AddValidatorsFromAssemblyContaining<DoctorsValidator>(); // register validators
builder.Services.AddValidatorsFromAssemblyContaining<EpisodeValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<EnemyValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<CompanionValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<AuthorValidator>();

builder.Services.AddFluentValidationAutoValidation(); // the same old MVC pipeline behavior
builder.Services.AddFluentValidationClientsideAdapters(); // for client side

builder.Services.AddDbContext<DoctorWhoDbContext>(DbContextOptions => DbContextOptions.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DoctorWhoCore"));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IEpisodeRepository, EpisodeRepository>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
