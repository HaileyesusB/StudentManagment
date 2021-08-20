using Microsoft.Extensions.Logging;
using Studmgt.Application.Common.Exceptions;
using Studmgt.Domain.Entity;
using Studmgt.Domain.Interfaces.Facade;
using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task Update(studentEntity studentEntity) 
        {
            try
            {
                await _studentRepository.Update(studentEntity.MapToModel());
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
                await _studentRepository.Delete(student);
            }
            catch (Exception e)
            {
                _logger.LogError($"Error Occured : {e.Message}");
                throw;
            }
        }

        public Task<studentEntity> UpdateStudent(studentEntity student)
        {
            Student studentModel = student.MapToModel();

            return (Task<studentEntity>)_studentRepository.Update(studentModel); 
        }


        public async Task<studentEntity> GetByIdAsync(Guid guid)
        {
            var stud = await _studentRepository.GetByIdAsync(guid);
            return new studentEntity(stud);
        }

        public async Task<IEnumerable<studentEntity>> GetAllStudents()
        {
            var studnt = await _studentRepository.GetAllAsync();
            return studnt?.Select(o => new studentEntity(o)).ToList();
        }
        public async Task<IEnumerable<studentEntity>> GetStudentByName(string studName)
        {
            try
            {
                var stud = (await _studentRepository.GetQueryAsync(x => x.Name== studName)).ToList();
                return stud?.Select(x => new studentEntity(x));
            }
            catch (Exception e)
            {

                _logger.LogError($"Error Occured : {e.Message}");
                return Enumerable.Empty<studentEntity>();
            }
        }

    }
}
