using DurableTask.Core.Common;
using Studmgt.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studmgt.Domain.Interfaces.Facade
{
    public interface IStudentService
    {
        Task<Guid> AddAsync(studentEntity studentEntity);
        Task UpdateAsync(studentEntity studentEntity);
    }
}
