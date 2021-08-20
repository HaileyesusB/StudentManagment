using Microsoft.Extensions.Logging;
using Studmgt.Application.Common.Exceptions;
using Studmgt.Domain.Entity;
using Studmgt.Domain.Interfaces.Facade;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studmgt.Application.Features
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository; 
        private readonly ILogger<CourseService> _logger;
        public CourseService(ICourseRepository courseRepository, ILogger<CourseService> logger)
        {
            _courseRepository = courseRepository;
            _logger = logger;
        }

        public async Task<Guid> AddAsync(CourseEntity courseEntity)
        {
            var model = courseEntity.MapToModel();
            var data = await _courseRepository.AddAsync(model);
            return data.Guid;
        }

        public async Task DeleteCourse(Guid guid)
        {
            try
            {
                var course = await _courseRepository.GetByIdAsync(guid);
                if (course == null)
                    throw new NotFoundException(nameof(course), guid);
                await _courseRepository.Delete(course);
            }
            catch (Exception e)
            {
                _logger.LogError($"Error Occured : {e.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<CourseEntity>> GetAllCourses()
        {
            var course = await _courseRepository.GetAllAsync();
            return course?.Select(o => new CourseEntity(o)).ToList();
        }

        public async Task<CourseEntity> GetByIdAsync(Guid guid)
        {
            var course = await _courseRepository.GetByIdAsync(guid);
            return new CourseEntity(course);
        }

        public async Task<IEnumerable<CourseEntity>> GetCourseByCode(string courseCode)
        {
            try
            {
                var course = (await _courseRepository.GetQueryAsync(x => x.Name == courseCode)).ToList();
                return course?.Select(x => new CourseEntity(x));
            }
            catch (Exception e)
            {

                _logger.LogError($"Error Occured : {e.Message}");
                return Enumerable.Empty<CourseEntity>();
            }
        }

        public async Task Update(CourseEntity courseEntity)
        {
            try
            {
                await _courseRepository.Update(courseEntity.MapToModel());
            }
            catch (Exception e)
            {
                _logger.LogError($"Error Occured : {e.Message}");
            }
        }
        

    }
}

