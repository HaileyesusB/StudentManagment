using Studmgt.Domain.Entity;
using Studmgt.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.Department.Queries.GetDepartmentList
{
    class GetDepartmentListQueryHandler
    {
        private readonly IDepartmentRepository _departmentRepository;
        public GetDepartmentListQueryHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository ?? throw new ArgumentNullException(nameof(departmentRepository));
        }

    }
}
