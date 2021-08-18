using DurableTask.Core.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studmgt.Domain.Interfaces.Facade
{
    public interface IStudentService
    {
        Task<List<Entity.studentEntity>> GetAllStudents();
        Task<Guid> Add(Entity.studentEntity students);
        Task<List<Entity.studentEntity>> GetByUser(string user);
        Task<Entity.studentEntity> GetOrder(Guid id);
        Task UpdateOrder(Entity.studentEntity order);
    }
}
