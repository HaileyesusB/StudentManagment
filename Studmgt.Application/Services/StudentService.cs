using Microsoft.Extensions.Logging;
using Studmgt.Application.Common.Exceptions;
using Studmgt.Domain.Entity;
using Studmgt.Domain.Interfaces.Facade;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System;
using System.Threading.Tasks;

namespace Redzone.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ILogger<StudentService> _logger;
        public StudentService(IStudentRepository studentRepository,ILogger<StudentService> logger)
        {
            _studentRepository = studentRepository;
            _logger = logger;
        }

        public async Task<Guid> AddAsync(studentEntity studentEntity)
        {
            var model = studentEntity.MapToModel();
            var data = await _studentRepository.AddAsync(model);
            return data.Guid;
        }

        public async Task UpdateAsync(studentEntity studentEntity)
        {
            try
            {
                await _studentRepository.UpdateAsync(studentEntity.MapToModel());
            }
            catch (Exception e)
            {
                _logger.LogError($"Error Occured : {e.Message}");
            }
        }

        public async Task DeleteStudent(Guid guid)
        {
            try
            {
                var student = await _studentRepository.GetByIdAsync(guid);
                if (student == null)
                    throw new NotFoundException(nameof(Student), guid);
                await _studentRepository.DeleteAsync(student);
            }
            catch (Exception e)
            {
                _logger.LogError($"Error Occured : {e.Message}");
                throw;
            }
        }


    }
}
