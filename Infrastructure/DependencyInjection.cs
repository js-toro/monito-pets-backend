using MonitoPetsBackend.Infrastructure.Attributes;

namespace MonitoPetsBackend.Infrastructure
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            Type scopedRegistration = typeof(ScopedRegistrationAttribute);
            Type singletonRegistration = typeof(SingletonRegistrationAttribute);
            Type transientRegistration = typeof(TransientRegistrationAttribute);

            var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => p.IsDefined(scopedRegistration, false) || p.IsDefined(transientRegistration, false) || p.IsDefined(singletonRegistration, false) && !p.IsInterface)
            .Select(s => new
            {
                Service = s.GetInterface($"I{s.Name}"),
                Implementation = s
            })
            .Where(x => x.Service != null);

            foreach (var type in types)
            {
                if (type.Implementation.IsDefined(scopedRegistration, false))
                {
                    services.AddScoped(type.Service, type.Implementation);
                }

                if (type.Implementation.IsDefined(transientRegistration, false))
                {
                    services.AddTransient(type.Service, type.Implementation);
                }

                if (type.Implementation.IsDefined(singletonRegistration, false))
                {
                    services.AddSingleton(type.Service, type.Implementation);
                }
            }

            return services;
        }
    }
}
