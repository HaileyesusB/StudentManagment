using MediatR;
using Studmgt.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studmgt.Application.Features.Student.Queries.GetStudentList
{

    public class GetStudentListQuery : IRequest<List<studentEntity>>
    {
        public string Name { get; set; }

        public GetStudentListQuery(string SName)
        {
            Name = SName ?? throw new ArgumentNullException(nameof(SName));
        }
    }
}
