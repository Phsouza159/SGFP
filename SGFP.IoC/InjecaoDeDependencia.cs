using Microsoft.Extensions.DependencyInjection;
using SGFP.Infra.DAO.DbContexto;

namespace SGFP.IoC
{
    public static class InjecaoDeDependencia
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<DbContexto>();
        }
    }
}
