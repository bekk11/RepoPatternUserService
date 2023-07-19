using Microsoft.EntityFrameworkCore;
using RepoPatternUserService.DAL;
using RepoPatternUserService.DAL.Interfaces;
using RepoPatternUserService.DAL.Repositories;
using RepoPatternUserService.Service.Implementations;
using RepoPatternUserService.Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<UserServiceDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresqlDbConfig"),
        (b => b.MigrationsAssembly("RepoPatternUserService"))));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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