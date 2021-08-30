using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Redzone.Application.Behaviours;
using Redzone.Application.Services;
using Studmgt.Domain.Interfaces.Facade;
using System.Reflection;

namespace Studmgt.Application
{
    public static class ApplicationService
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            services.AddScoped<IStudentService, StudentService>();

            return services;
        }
    }
}
