using Studmgt.Domain.Entity;
using Studmgt.Domain.Interfaces.Facade;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studmgt.Application.Features
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public async Task<int>  Add(CourseEntity courseEntity)
        {
            Course course = courseEntity.MapToModel();
             await _courseRepository.AddAsync(course);
            return course.Id;
        }

        public async Task<List<CourseEntity>> GetAllCourseEntities()
        {
          var data = await _courseRepository.GetAllAsync();
            return data?.Select(x => new CourseEntity(x)).ToList();
        }

        public async Task<CourseEntity> GetCourseEntity(int Id)
        {
            Course course = await _courseRepository.GetByIdAsync(Id);
            return new CourseEntity(course);
        }

        public bool Remove(int Id)
        {
            return _courseRepository.Delete(Id);
        }

        public bool UpdateCourse(CourseEntity courseEntity)
        {
            Course course = courseEntity.MapToModel();
            return _courseRepository.Update(course);
        }
    }
}
