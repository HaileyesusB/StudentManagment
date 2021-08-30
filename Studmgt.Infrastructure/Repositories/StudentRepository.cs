using Studmgt.Domain.Interfaces.Repository;
using Studmgt.Domain.Model;
using Studmgt.Infrastructure.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Studmgt.Infrastructure.Repositories
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        

        public StudentRepository(DataBaseContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Student>> GetStudentByUserName(string name)
        {
            var orderList = (await GetQueryAsync(x => x.Name == name));
            return orderList;
        }
    }
}
