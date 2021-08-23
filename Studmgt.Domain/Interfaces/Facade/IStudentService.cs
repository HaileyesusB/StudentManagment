using Studmgt.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studmgt.Domain.Interfaces.Facade
{
    public interface IStudentService
    {
        Task<IEnumerable<studentEntity>> GetStudentByName(string studName); 
        Task<Guid> AddAsync(studentEntity studentEntity);
        Task Update(studentEntity studentEntity);
        Task<studentEntity> GetByIdAsync(Guid guid);
        Task<IEnumerable<studentEntity>> GetAllStudents();
        Task DeleteStudent(Guid guid); 

    }
}
