using MediatR;
using Microsoft.Extensions.Logging;
using Studmgt.Application.Common.Exceptions;
using Studmgt.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.Department.Command.UpdateDepartment
{
    class UpdateDepartmentCommandHandler: IRequestHandler<UpdateDepartmentCommand>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ILogger<UpdateDepartmentCommand> _logger;
        public UpdateDepartmentCommandHandler(IDepartmentRepository departmentRepository, ILogger<UpdateDepartmentCommand> logger)
        {
            _departmentRepository = departmentRepository;
            _logger = logger;
        }
        public async Task<Unit> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {

            var departmentToUpdate = await _departmentRepository.GetByIdAsync(request.Guid);
            if (departmentToUpdate == null)
            {
                throw new NotFoundException(nameof(Student), request.Guid);
            }
            var model = request.MapToModel(departmentToUpdate);
            await _departmentRepository.Update(model);
            _logger.LogInformation($"Department {departmentToUpdate.Guid} is successfully updated.");
            return Unit.Value;

        }
    }
}
