using MediatR;
using Studmgt.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Application.Features.Department.Command.UpdateDepartment
{
    class UpdateDepartmentCommand: DepartmentEntity, IRequest
    {
    }
}
