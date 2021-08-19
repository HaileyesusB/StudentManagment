using Studmgt.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Studmgt.Domain.Interfaces.Facade
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseEntity>> GetCourseByCode(string cCode); 
        Task<Guid> AddAsync(CourseEntity courseEntity); 
        Task UpdateAsync(CourseEntity courseEntity);
        Task<CourseEntity> GetByIdAsync(Guid guid);
        Task<IEnumerable<CourseEntity>> GetAllCourses();
        Task DeleteCoourse(Guid guid);

    }

}
