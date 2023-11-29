using ASPNET6MinimalAPI.Model;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ITodoRep, TodoItemRepImplement>();
var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseSwagger();


var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/api/todo/all", ([FromServices] ITodoRep todoRep) =>
{
    return todoRep.GetAll();
});
app.MapGet("/api/todo/{id}", ([FromServices] ITodoRep todoRep, int id) =>
{
    return todoRep.GetById(id);
});

app.MapPost("/api/todo", ([FromServices] ITodoRep todoRep, TodoItem item) =>
{
    TodoItem result = todoRep.CreateNewTodoItem(item);
    return result;
});

app.UseSwaggerUI();
app.Run();
internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}