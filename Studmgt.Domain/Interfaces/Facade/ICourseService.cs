using Studmgt.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Studmgt.Domain.Interfaces.Facade
{
   public interface ICourseService
    {
        Task<List<CourseEntity>> GetAllCourseEntities();
        Task<CourseEntity> GetCourseEntity(int Id);
        Task<int> Add(CourseEntity courseEntity);
        bool Remove(int Id);
        bool UpdateCourse(CourseEntity course);
    }
}
