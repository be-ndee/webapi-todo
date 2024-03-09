using Microsoft.EntityFrameworkCore;
using webapi_todo.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<UserContext>(opt => opt.UseInMemoryDatabase("Users"));
builder.Services.AddDbContext<TodoItemContext>(opt => opt.UseInMemoryDatabase("TodoItems"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();