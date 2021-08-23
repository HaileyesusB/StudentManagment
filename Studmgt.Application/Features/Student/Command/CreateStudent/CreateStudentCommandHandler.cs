using MediatR;
using Microsoft.Extensions.Logging;
using Studmgt.Domain.Entity;
using Studmgt.Domain.Interfaces.Repository;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.Student.Command.CreateStudent
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Guid>
        {
            private readonly IStudentRepository _studentRepository;
            private readonly ILogger<CreateStudentCommand> _logger;
            public CreateStudentCommandHandler(IStudentRepository studentRepository, ILogger<CreateStudentCommand> logger)
            {
                _studentRepository = studentRepository ?? throw new ArgumentNullException(nameof(studentRepository));
                _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            }
            public async Task<Guid> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
            {
                var student = request.MapToModel();
                var newOrder = await _studentRepository.AddAsync(student);
                _logger.LogInformation($"Student {newOrder.Guid} is successfully created.");
                return newOrder.Guid;
            }

  
    }
    }

