using DurableTask.Core.Common;
using Studmgt.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studmgt.Domain.Interfaces.Facade
{
    public interface IStudentService
    {

     //  Task<IEnumerable<studentEntity>> GetStudentByUser(string userName);
        Task<Guid> AddAsync(studentEntity studentEntity);
        Task UpdateAsync(studentEntity studentEntity);
        //  Task<IEnumerable<studentEntity>> GetAllStudent();
       // Task<studentEntity> DeleteStudent(Guid guid);

    }
}
