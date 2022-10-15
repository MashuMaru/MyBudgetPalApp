using MyBudgetPal.Data.Interfaces;
using MyBudgetPal.Data.Repositories;
using MyBudgetPal.Handlers;
using MyBudgetPal.Interfaces;
using TodoApp.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<DbContext>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddTransient<IAuthHandler, AuthHandler>();
builder.Services.AddTransient<IAuthRepository, AuthRepository>();
builder.Services.AddTransient<IUserRepository, UsersRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
if (app.Environment.IsProduction()) 
{
    app.UseHttpsRedirection();
} 

app.UseAuthorization();

app.MapControllers();

app.Run();
