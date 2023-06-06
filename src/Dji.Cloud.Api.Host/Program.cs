using Asp.Versioning;
using Dji.Cloud.Application.Abstracts.Configurations;
using Dji.Cloud.Application.Commands.Manage;
using Dji.Cloud.Application.Validators;
using Dji.Cloud.Infrastructure.Host.Configurations;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Text.Json.Serialization;

const string apiVersioningHeaderName = "x-api-version";

const string swaggerMediaType = "application/json";

const string tokenConfigurationSectionName = "TokenConfiguration";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(configure => {
    configure.Filters.Add(new ProducesAttribute(swaggerMediaType));
    configure.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status400BadRequest));
    configure.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status401Unauthorized));
    configure.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status403Forbidden));
    configure.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status404NotFound));
    configure.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status500InternalServerError));
}).AddJsonOptions(configure => configure.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

// Configure Auto Mapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Configure repositories
builder.Services.ConfigureRepositories(builder.Configuration);

// Configure services
builder.Services.ConfigureServices();

// Configure validators
builder.Services.AddValidatorsFromAssemblyContaining<UserLoginRequestValidator>();

// Configure Mediator R
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(UserLoginCommand).GetTypeInfo().Assembly));

// Configure Api Versioning
builder.Services.AddApiVersioning(options =>
{
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true; 
    options.DefaultApiVersion = new Asp.Versioning.ApiVersion(1, 0);
    options.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
                                                        new HeaderApiVersionReader(apiVersioningHeaderName),
                                                        new MediaTypeApiVersionReader(apiVersioningHeaderName));
});

// Configure token configuration
builder.Services.Configure<TokenConfiguration>(builder.Configuration.GetSection(tokenConfigurationSectionName));

// Configure Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
