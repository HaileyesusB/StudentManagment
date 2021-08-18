using Studmgt.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Studmgt.Domain.Interfaces.Facade
{
   public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentEntity>> GetDepartmentByName(string deptName); 
        Task<Guid> AddAsync(DepartmentEntity departmentEntity); 
        Task UpdateAsync(DepartmentEntity departmentEntity);
        Task<DepartmentEntity> GetByIdAsync(Guid guid);
        Task<IEnumerable<DepartmentEntity>> GetAllDeparments();  
        Task DeleteDepartment(Guid guid); 
    }
}
