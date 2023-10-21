using Autofac;
using Autofac.Extensions.DependencyInjection;
using Jazani.Application.Cores.Contexts;
using Jazani.Infraestructure.Cores.Contexts;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Infraestructure
builder.Services.addInfraestructureServices(builder.Configuration);

//Application
builder.Services.AddApplicationServices();

//Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(option =>
    {
        option.RegisterModule(new InfraestructureAutofacModule());
        option.RegisterModule(new ApplicationAutofacModule());
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
