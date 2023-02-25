using Zti.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IStudentService, StudentService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
