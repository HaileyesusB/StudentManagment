using DurableTask.Core.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studmgt.Domain.Interfaces.Facade
{
    public interface IStudentService
    {
        Task<List<Entity.studentEntity>> GetAllStudents();
        
        Task<Entity.studentEntity> GetStudent(Guid id);

        Task<Guid> AddAsync(Entity.studentEntity students);

        Task<Guid> UpdateStudent(Entity.studentEntity Student);

        Task<Entity.studentEntity> DeleteStudent(Guid id);

        Task EditStudent(Entity.studentEntity Student);


    }
}
