using DesignPatterns.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Infraestructure.DependencyInjection
{
    public class ServicesConfiguration
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IVehicleRepository, MyVehiclesRepository>();
        }
    }
}
