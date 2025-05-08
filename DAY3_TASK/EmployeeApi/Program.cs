using EmployeeApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<DapperContext>();
builder.Services.AddScoped<EmployeeRepository>();

var app = builder.Build();

app.MapControllers();

app.Run();
