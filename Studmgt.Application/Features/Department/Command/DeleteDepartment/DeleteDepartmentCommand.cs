using MediatR;
using System;

namespace Studmgt.Application.Features.Department.Command.DeleteDepartment
{
    public class DeleteDepartmentCommand: IRequest
    {
        public Guid Id { get; set; }
    }
}
