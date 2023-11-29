using curso_aspnet_api.Domain.Interfaces.Services.Cep;
using curso_aspnet_api.Domain.Interfaces.Services.Municipio;
using curso_aspnet_api.Domain.Interfaces.Services.Uf;
using curso_aspnet_api.Domain.Interfaces.Services.User;
using curso_aspnet_api.Service.Services;
using curso_aspnet_api.Service.Services.Cep;
using curso_aspnet_api.Service.Services.Municipio;
using curso_aspnet_api.Service.Services.Uf;
using Microsoft.Extensions.DependencyInjection;

namespace curso_aspnet_api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUserService, UserService>();
            serviceCollection.AddScoped<ILoginService, LoginService>();

            serviceCollection.AddScoped<ICepService, CepService>();
            serviceCollection.AddScoped<IMunicipioService, MunicipioService>();
            serviceCollection.AddScoped<IUfService, UfService>();
        }
    }
}