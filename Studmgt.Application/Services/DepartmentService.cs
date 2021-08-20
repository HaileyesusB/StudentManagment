using Microsoft.Extensions.Logging;
using Studmgt.Application.Common.Exceptions;
using Studmgt.Domain.Entity;
using Studmgt.Domain.Interfaces.Facade;
using Studmgt.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studmgt.Application.Services
{
    class DepartmentService: IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository; 
        private readonly ILogger<DepartmentService> _logger;
        public DepartmentService(IDepartmentRepository departmentRepository, ILogger<DepartmentService> logger)
        {
            _departmentRepository = departmentRepository;
            _logger = logger;
        }

        public async Task<Guid> AddAsync(DepartmentEntity departmentEntity)
        {
            var model = departmentEntity.MapToModel();
            var data = await _departmentRepository.AddAsync(model);
            return data.Guid;
        }

        public async Task DeleteDepartment(Guid guid)
        {
            try
            {
                var department = await _departmentRepository.GetByIdAsync(guid);
                if (department == null)
                    throw new NotFoundException(nameof(department), guid);
                await _departmentRepository.Delete(department);
            }
            catch (Exception e)
            {
                _logger.LogError($"Error Occured : {e.Message}");
                throw;
            }
        }
    

        public async Task<IEnumerable<DepartmentEntity>> GetAllDeparments()
        {
            var department = await _departmentRepository.GetAllAsync(); 
            return department?.Select(o => new DepartmentEntity(o)).ToList();
        }

        public async Task<DepartmentEntity> GetByIdAsync(Guid guid)
        {
            var department = await _departmentRepository.GetByIdAsync(guid);
            return new DepartmentEntity(department);
        }

        public async Task<IEnumerable<DepartmentEntity>> GetDepartmentByName(string deptName)
        {
            try
            {
                var department = (await _departmentRepository.GetQueryAsync(x => x.Name == deptName)).ToList();
                return department?.Select(x => new DepartmentEntity(x));
            }
            catch (Exception e)
            {

                _logger.LogError($"Error Occured : {e.Message}");
                return Enumerable.Empty<DepartmentEntity>();
            }
        }
        public async Task Update(DepartmentEntity departmentEntity)
        {
            try
            {
                await _departmentRepository.Update(departmentEntity.MapToModel());
            }
            catch (Exception e)
            {
                _logger.LogError($"Error Occured : {e.Message}");
            }
        }

       
    }
}
