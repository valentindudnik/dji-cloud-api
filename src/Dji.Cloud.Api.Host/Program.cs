using Asp.Versioning;
using Dji.Cloud.Application.Abstracts.Configurations;
using Dji.Cloud.Application.Validators;
using Dji.Cloud.Infrastructure.Host.Configurations;
using FluentValidation;
using System.Reflection;

const string apiVersioningHeaderName = "x-api-version";

const string tokenConfigurationSectionName = "TokenConfiguration";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure Auto Mapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Configure repositories
builder.Services.ConfigureRepositories(builder.Configuration);

// Configure services
builder.Services.ConfigureServices();

// Configure validators
builder.Services.AddValidatorsFromAssemblyContaining<UserLoginRequestValidator>();

// Configure Mediator R
builder.Services.AddMediatR(configure => configure.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

// Configure Api Versioning
builder.Services.AddApiVersioning(options =>
{
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true; 
    options.DefaultApiVersion = new ApiVersion(1, 0);
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
