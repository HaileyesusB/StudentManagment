using MediatR;
using Studmgt.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Application.Features.Department.Queries.GetDepartmentList
{
    class GetDepartmentListQuery:IRequest<List<DepartmentEntity>>
    {
        public string Name { get; set; }
        public GetDepartmentListQuery(string departmentName)
        {
            Name = departmentName ?? throw new ArgumentNullException(nameof(departmentName));
        }
    }
}
