using ECart.Application.Business.Services;
using ECart.Application.Core.Interfaces;
using ECart.Application.Repository.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ECart.Application.Api
{
    public static class DependencyRegister
    {
        public static void RegisterDependency(this IServiceCollection services)
        {
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IRepositoryService, RepositoryService>();
            services.AddScoped<ICartItemService, CartItemService>();
        }
    }
}
