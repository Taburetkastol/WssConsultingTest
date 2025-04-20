using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Services;
using Persistence;
using Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistence(builder.Configuration);

builder.Services.AddScoped<IDivisionRepository, MsSqlDivisionRepository>();
builder.Services.AddScoped<IDivisionService, DivisionService>();
builder.Services.AddScoped<IXmlExportService, XmlExportService>();

builder.Services.AddControllers();

var app = builder.Build();

app.Run();