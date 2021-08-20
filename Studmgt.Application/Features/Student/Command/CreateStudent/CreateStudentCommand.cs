using MediatR;
using Studmgt.Domain.Entity;
using System;

namespace Studmgt.Application.Features.Student.Command.CreateStudent
{
    public class CreateStudentCommand : studentEntity, IRequest<Guid>
    {
    }
}

