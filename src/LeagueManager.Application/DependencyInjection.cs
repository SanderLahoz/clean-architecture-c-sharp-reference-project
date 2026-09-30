using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace LeagueManager.Application
{
    /// <summary>
    /// Provides extension methods for registering Application layer services, 
    /// MediatR handlers, and FluentValidation validators into the .NET DI container.
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// Registers all Application layer dependencies (MediatR request handlers, pipeline behaviors, 
        /// and FluentValidation validators) into the provided <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The service collection where dependencies are registered.</param>
        /// <returns>The same service collection to support method chaining.</returns>
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Retrieve the Assembly object for the Application project (LeagueManager.Application.dll).
            // This allows DI packages to scan the assembly for classes implementing specific interfaces.
            var currentAssembly = typeof(DependencyInjection).Assembly;

            // Automatically scans the Application assembly and registers all MediatR handlers
            // (e.g., classes implementing IRequestHandler<TRequest, TResponse>).
            services.AddMediatR(config => config.RegisterServicesFromAssembly(currentAssembly));
            
            // Automatically scans the Application assembly and registers all FluentValidation classes
            // (e.g., classes inheriting from AbstractValidator<T>) as IValidator<T>.
            services.AddValidatorsFromAssembly(currentAssembly);
            
            // Return the service collection to allow fluent method chaining in Program.cs
            return services;
        }
    }
}