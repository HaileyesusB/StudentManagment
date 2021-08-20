using MediatR;
using Microsoft.Extensions.Logging;
using Studmgt.Application.Common.Exceptions;
using Studmgt.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.Student.Command.UpdateStudent
{
   
        public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand>
        {
            private readonly IStudentRepository _studentRepository;
            private readonly ILogger<UpdateStudentCommand> _logger;
            public UpdateStudentCommandHandler(IStudentRepository studentRepository, ILogger<UpdateStudentCommand> logger)
            {
                _studentRepository = studentRepository;
                _logger = logger;
            }
            public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
            {

                var studentToUpdate = await _studentRepository.GetByIdAsync(request.Guid);
                if (studentToUpdate == null)
                {
                    throw new NotFoundException(nameof(Student), request.Guid);
                }
                var model = request.MapToModel(studentToUpdate);
                await _studentRepository.UpdateAsync(model);
                _logger.LogInformation($"Order {studentToUpdate.Guid} is successfully updated.");
                return Unit.Value;

            }
        }


    }
