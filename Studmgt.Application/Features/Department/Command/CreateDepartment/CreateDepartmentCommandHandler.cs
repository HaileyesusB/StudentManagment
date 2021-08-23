using MediatR;
using Microsoft.Extensions.Logging;
using Studmgt.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Application.Features.Department.Command.CreateDepartment
{
    public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, Guid>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ILogger<CreateDepartmentCommand> _logger;
        public CreateDepartmentCommandHandler(IDepartmentRepository departmentRepository, ILogger<CreateDepartmentCommand> logger)
        {
            _departmentRepository = departmentRepository ?? throw new ArgumentNullException(nameof(departmentRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<Guid> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = request.MapToModel();
            var newDepartment = await _departmentRepository.AddAsync(department);
            _logger.LogInformation($"Department {newDepartment.Guid} is successfully created.");
            return newDepartment.Guid;
        }

    }
}
