using DOTNET.TEMPLATE.BUSINESS.USER;
using DOTNET.TEMPLATE.DATAACCESS;
using DOTNET.TEMPLATE.SERVICES;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Create services to the container.
builder.Services.AddSingleton<IUser, UserService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyContextDb>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("db"));
    option.EnableSensitiveDataLogging();
});

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
