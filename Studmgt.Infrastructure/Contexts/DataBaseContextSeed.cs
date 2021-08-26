using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Studmgt.Domain.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studmgt.Infrastructure.Contexts
{
    public class DataBaseContextSeed
    {
            public static async Task SeedAsync(DataBaseContext dbContext, ILogger<DataBaseContextSeed> logger)
            {
                if (!dbContext.students.Any())
                {
                dbContext.students.AddRange(GetPreconfiguredStudent());
                    await dbContext.SaveChangesAsync();
                    logger.LogInformation("Seed database associated with context {DbContextName}", typeof(DbContext).Name);

                }
            }
        private static IEnumerable<Student> GetPreconfiguredStudent()
        {
            return new List<Student>
            {
                new Student() {Name = "user", Adress = "Unconditional", Age = 20 , Department = "department"}
            };
        }

    }
}
