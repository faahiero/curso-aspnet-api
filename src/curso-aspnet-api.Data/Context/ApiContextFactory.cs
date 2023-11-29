using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace curso_aspnet_api.Data.Context
{
    public class ApiContextFactory : IDesignTimeDbContextFactory<ApiDataContext>
    {
        public ApiDataContext CreateDbContext(string[] args)
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var appPath = Path.GetFullPath(Path.Combine(basePath, "..", "..", "..", "..", "curso-aspnet-api.Application"));
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(appPath)
                .AddJsonFile("appsettings.json")
                .Build();

            var mySqlConnection = configuration.GetConnectionString("MySqlConnection");
            var sqlServerConnection = configuration.GetConnectionString("SqlServerConnection");
            var optionsBuilder = new DbContextOptionsBuilder<ApiDataContext>();
            optionsBuilder.UseSqlServer(sqlServerConnection,sql => sql.EnableRetryOnFailure());

            return new ApiDataContext(optionsBuilder.Options);
        }
    }
}