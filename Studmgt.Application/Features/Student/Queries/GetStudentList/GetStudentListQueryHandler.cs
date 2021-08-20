using Studmgt.Domain.Entity;
using Studmgt.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.Student.Queries.GetStudentList
{
   public  class GetStudentListQueryHandler
    {
        private readonly IStudentRepository _studentRepository;
        public GetStudentListQueryHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository ?? throw new ArgumentNullException(nameof(studentRepository));
        }
        public async Task<List<studentEntity>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var studentList = await _studentRepository.GetStudentByUserName(request.Name);
            return studentList?.Select(o => new studentEntity(o)).ToList();

        }
    }

}

