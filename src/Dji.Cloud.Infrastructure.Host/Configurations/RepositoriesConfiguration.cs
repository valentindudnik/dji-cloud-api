using Dji.Cloud.Infrastructure.Abstracts.Interfaces;
using Dji.Cloud.Infrastructure.MySql.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dji.Cloud.Infrastructure.Host.Configurations;

public static class RepositoriesConfiguration
{
    //private const string defaultMsSqlConnectionString = "DefaultMsSqlConnection";
    private const string defaultMySqlConnectionString = "DefaultMySqlConnection";

    public static void ConfigureRepositories(this IServiceCollection services, IConfiguration configuration) 
    {
        // Configure Dji DB

        //// Configure MsSql
        //services.AddDbContext<DjiDbContext>(x => x.UseSqlServer(configuration.GetConnectionString(defaultMsSqlConnectionString), options => options.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds)));
        //services.AddScoped(typeof(IGenericRepository<>), typeof(MsSql.Repositories.GenericRepository<>));

        // Configure MySql
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 33));
        services.AddDbContext<MySql.DataContexts.DjiDbContext>(x => x.UseMySql(configuration.GetConnectionString(defaultMySqlConnectionString), serverVersion, options => options.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds)));
        services.AddScoped(typeof(IGenericRepository<>), typeof(MySql.Repositories.GenericRepository<>));
        services.AddScoped(typeof(IDeviceFirmwareRepository), typeof(DeviceFirmwareRepository));
    }
}
