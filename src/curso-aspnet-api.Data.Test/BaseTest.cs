using System;
using curso_aspnet_api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace curso_aspnet_api.Data.Test
{
    public abstract class BaseTest
    {
    }

    public class DbTeste : IDisposable
    {
        private string dataBaseName = $"dbAPI_{Guid.NewGuid().ToString().Replace("-", string.Empty)}";
        public ServiceProvider ServiceProvider { get; private set; }


        public DbTeste()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<ApiDataContext>(o =>
                    o.UseMySql(
                        $"Server=localhost;Port=3306;Database={dataBaseName};Uid=root;Pwd=root;AllowPublicKeyRetrieval=True;SSL Mode=None"),
                ServiceLifetime.Transient);

            ServiceProvider = serviceCollection.BuildServiceProvider();
            using var context = ServiceProvider.GetService<ApiDataContext>();
            context.Database.EnsureCreated();
        }
        public void Dispose()
        {
            using var context = ServiceProvider.GetService<ApiDataContext>();
            context.Database.EnsureDeleted();
        }
    }
}