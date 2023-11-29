using curso_aspnet_api.Data.Context;
using curso_aspnet_api.Data.Repository;
using curso_aspnet_api.Data.Repository.Cep;
using curso_aspnet_api.Data.Repository.Municipio;
using curso_aspnet_api.Data.Repository.Uf;
using curso_aspnet_api.Data.Repository.User;
using curso_aspnet_api.Domain.Interfaces;
using curso_aspnet_api.Domain.Interfaces.Repository;
using curso_aspnet_api.Domain.Interfaces.Repository.Cep;
using curso_aspnet_api.Domain.Interfaces.Repository.Municipio;
using curso_aspnet_api.Domain.Interfaces.Repository.Uf;
using curso_aspnet_api.Domain.Interfaces.Repository.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace curso_aspnet_api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserRepository>();

            serviceCollection.AddScoped<IMunicipioRepository, MunicipioRepository>();
            serviceCollection.AddScoped<ICepRepository, CepRepository>();
            serviceCollection.AddScoped<IUfRepository, UfRepository>();

            serviceCollection.AddDbContext<ApiDataContext>(opt =>
            {
                var mySqlConnection = configuration.GetConnectionString("MySqlConnection");
                var sqlServerConnection = configuration.GetConnectionString("SqlServerConnection");
                opt.UseSqlServer(sqlServerConnection, sql => sql.EnableRetryOnFailure());
            });
        }
    }
}