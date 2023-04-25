using Microsoft.AspNetCore.Authentication;
using AngularCoreTemplate.Services;

namespace AngularCoreTemplate.Extensions
{
    public static class AddCompanyServicesExtensions
    {
        public static void AddCompanyServices(this IServiceCollection services)
        {
            services.AddTransient<HelloWorldService>();           

            services.AddScoped<IHelloWorldService>(provider =>
            {
                var ctx = provider.GetRequiredService<IHttpContextAccessor>();
                
                return provider.GetRequiredService<HelloWorldService>();
                   
            });


        }
    }
}
