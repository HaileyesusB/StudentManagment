using Microsoft.Extensions.Logging;
using Studmgt.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studmgt.Infrastructure.Contexts
{
    public class StudMgtContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext dbContext, ILogger<StudMgtContextSeed> logger)
        {
            if (!dbContext.Courses.Any())
            {
                dbContext.Courses.AddRange(GetPreconfiguredCourses());
                await dbContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(ApplicationDbContext).Name);

            }
        }

        
        private static IEnumerable<Course> GetPreconfiguredCourses()
        { 
            return new List<Course>
            {
                new Course() {Name = "Angular", Code = "Anr002", Description = "test for project" }
            };
        }
    }
}
