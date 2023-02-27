using LarningFullStackApplication.Interfaces;
using LarningFullStackApplication.Services;
using LarningFullStackData.Repositories;
using LarningFullStackDomain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Larning.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services
            services.AddScoped<IUserService, UserService>();
            #endregion

            #region Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion
        }

    }
}
