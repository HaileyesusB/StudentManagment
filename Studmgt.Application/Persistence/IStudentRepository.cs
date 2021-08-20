using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Studmgt.Application.Persistence
{
    public interface IStudentRepository : IAsyncRepository<Student>
    {
        Task<IEnumerable<Student>> GetStudentById(string id);
    }
}
