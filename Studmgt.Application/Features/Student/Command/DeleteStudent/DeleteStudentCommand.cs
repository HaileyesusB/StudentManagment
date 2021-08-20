using MediatR;
using System;

namespace Studmgt.Application.Features.Student.Command.DeleteStudent
{

    public class DeleteStudentCommand : IRequest
        {
            public Guid ID { get; set; }
        }
    }
