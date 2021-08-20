using MediatR;
using System;

namespace Studmgt.Application.Features.Course.Command.DeleteCourse
{
    public class DeleteCourseCommand : IRequest
    {
        public Guid ID { get; set; }
    }
}
