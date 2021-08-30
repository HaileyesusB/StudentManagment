using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Seeds;
using Studmgt.Infrastructure.Contexts;
using Studmgt.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Infrastructure
{
  public static class InfrastructureServiceRegistation
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataBaseContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("OrderingConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}
