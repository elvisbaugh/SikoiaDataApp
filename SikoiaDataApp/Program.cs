using SikoiaDataApp.Domain.Models;
using SikoiaDataApp.Domain.Models.Abstraction;
using SikoiaDataApp.Domain.Models.Response;
using SikoiaDataApp.Domain.Models.ThirdPartyBResponse;
using SikoiaDataApp.Domain.ServiceClients.Abstraction;
using SikoiaDataApp.Domain.ServiceClients.Implementation;
using SikoiaDataApp.Domain.Services;
using SikoiaDataApp.Domain.Services.Abstraction;
using SikoiaDataApp.Domain.Services.Implementation;
using SikoiaDataApp.WebServices.Mapping;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
     .AddJsonOptions(options =>
     {
         options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
     });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IBaseRegionData, ThirdPartyBData>(); 
builder.Services.AddTransient<IBaseRegionData, ThirdPartyARegionData>();
builder.Services.AddTransient<IBaseRegionData, ThirdPartyBRegionData>();
builder.Services.AddTransient<IRegionService, RegionService>(); 
builder.Services.AddTransient<IDataServiceStrategyFactory, DataServiceStrategyFactory>(); 
builder.Services.AddTransient<IThirdPartyACommunicationClient, ThirdPartyACommunicationClient>(); 
builder.Services.AddTransient<IThirdPartyBCommunicationClient, ThirdPartyBCommunicationClient>();
builder.Services.AddTransient<IDataServiceStrategy, UKDataService>(); 
builder.Services.AddTransient<IDataServiceStrategy, NetherlandDataService>();
builder.Services.AddAutoMapper(typeof(DataProviderProfile));

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
