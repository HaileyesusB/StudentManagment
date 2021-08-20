using MediatR;
using Microsoft.Extensions.Logging;
using Studmgt.Domain.Interfaces.Repository;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.Course.Command.CreateCourse
{
   public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, Guid>
    {
        private readonly ICourseRepository _courseRepository; 
        private readonly ILogger<CreateCourseCommandHandler> _logger;
        public CreateCourseCommandHandler(ICourseRepository courseRepository, ILogger<CreateCourseCommandHandler> logger)
        {
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<Guid> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = request.MapToModel();
            var newCourse = await _courseRepository.AddAsync(course);
            _logger.LogInformation($"Course {newCourse.Code} is successfully created.");
            return newCourse.Guid;
        }
    }
}
