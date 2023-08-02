using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ConfigFunctionDemo.Configuration
{
    internal static class ServiceCollectionExtensions
    {
        public static void AddOptions(this IServiceCollection services)
        {
            services.AddOptions<ParentOptions>()
                .Configure<IConfiguration>((settings, configuration) =>
                {
                    configuration.GetSection("ParentOptions").Bind(settings);
                });

            services.Add(new ServiceDescriptor(typeof(ParentOptions), provider =>
            {
                var options = provider.GetRequiredService<IOptions<ParentOptions>>();
                return options.Value;
            }, ServiceLifetime.Singleton));
        }
    }
}