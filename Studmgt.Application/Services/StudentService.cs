using Microsoft.Extensions.Logging;
using Studmgt.Application.Common.Exceptions;
using Studmgt.Application.Services;
using Studmgt.Domain.Entity;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
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

        public async Task DeleteOrder(Guid guid)
        {
            try
            {
                var order = await _studentRepository.GetByIdAsync(guid);
                if(order == null)
                    throw new NotFoundException(nameof(Student), guid);
                await _studentRepository.DeleteAsync(order);
            }
            catch (Exception e)
            {
                _logger.LogError($"Error Occured : {e.Message}");
                throw;
            }
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
    }
}
