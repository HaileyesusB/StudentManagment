using MediatR;
using Studmgt.Domain.Entity;
using System;


namespace Studmgt.Application.Features.Course.Command.CreateCourse
{
    public class CreateCourseCommand : CourseEntity, IRequest<Guid> 
    {
    }
}
