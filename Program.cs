using MediatR;
using MediatRPattern.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());

builder.Services.AddSingleton<IEmployeeService, EmployeeService>();


var app = builder.Build();


app.UseAuthorization();

app.MapControllers();

app.Run();
