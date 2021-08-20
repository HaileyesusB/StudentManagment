using MediatR;
using Studmgt.Domain.Entity;
using Studmgt.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.Course.Queries.GetCourseList
{

    //public class GetCourseListQueryHandler : IRequestHandler<GetCourseListQuery, List<CourseEntity>>
    //{
    //    private readonly ICourseRepository _courseRepository;
    //    public GetCourseListQueryHandler(ICourseRepository courseRepository)
    //    {
    //        _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
    //    }
    //    public async Task<List<CourseEntity>> Handle(GetCourseListQuery request, CancellationToken cancellationToken)
    //    {
    //        var orderList = await _courseRepository.GetCourseByCourseCode(request.Code);
    //        return orderList?.Select(o => new CourseEntity(o)).ToList();

    //    }
    //}
}
