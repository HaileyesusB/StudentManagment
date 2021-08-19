using Studmgt.Domain.Entity;
using Studmgt.Domain.Interfaces.Facade;
using Studmgt.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Studmgt.Application.Features
{

    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studRepository = studentRepository;
        }
        public async Task<Guid> Add(Domain.Entity.studentEntity student)
        {
            Studmgt.Domain.Model.Student studentModel = student.MapToModel();
            await _studRepository.AddAsync(studentModel);
            return studentModel.Guid;
        }
        public Task<List<studentEntity>> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entity.studentEntity> GetStudent(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

