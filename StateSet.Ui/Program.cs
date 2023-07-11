using StateSet.IoC.Bll;
using StateSet.IoC.Dal;
using StateSet.IoC.LogManagement;
using StateSet.Ui.Middleware;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.BllDependenciesInjections(builder.Configuration);
builder.Services.DalDependenciesInjections(builder.Configuration);
builder.Services.LogManagementDependenciesInjections();




builder.Services.AddControllers();
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

app.UseCrudRequestLog();

app.UseAuthorization();

app.MapControllers();


app.Run();

