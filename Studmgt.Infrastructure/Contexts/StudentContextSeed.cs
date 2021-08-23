using Microsoft.Extensions.Logging;
using Studmgt.Domain.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studmgt.Infrastructure.Contexts
{
    public class StudentContextSeed
        {
            public static async Task SeedAsync(StudentContext studentContext, ILogger<StudentContextSeed> logger)
            {
                if (!studentContext.students.Any())
                {
                studentContext.students.AddRange(GetPreconfiguredStudent());
                    await studentContext.SaveChangesAsync();
                    logger.LogInformation("Seed database associated with context {DbContextName}", typeof(StudentContext).Name);

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
