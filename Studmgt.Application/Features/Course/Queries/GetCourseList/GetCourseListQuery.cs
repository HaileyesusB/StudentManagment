using MediatR;
using Studmgt.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Application.Features.Course.Queries.GetCourseList
{
    class GetCourseListQuery : IRequest<List<CourseEntity>>
    {
        public string Code { get; set; }

        public GetCourseListQuery(string CourseCode)
        {
            Code = CourseCode ?? throw new ArgumentNullException(nameof(CourseCode));
        }
    }
}
