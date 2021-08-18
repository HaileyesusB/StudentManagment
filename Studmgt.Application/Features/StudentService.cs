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

        //public Task<Guid> Add (studentEntity students)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<List<Domain.Entity.studentEntity>> GetAllStudent()
        //    {
        //        var data = await _studRepository.GetAllAsync();
        //        return data?.Select(x => new Domain.Entity.studentEntity(x)).ToList();
        //    }

        public Task<List<studentEntity>> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        //public async Task<List<Domain.Entity.studentEntity>> GetByStudent(string sex)
        //    {
        //        var data = _studRepository.GetAsync(x => x.sex == sex);
        //        List<Domain.Entity,studentEntity> orders = (await data).Select(x => new Domain.Entity.studentEntity(x)).ToList();
        //        return orders;
        //    }

            public Task<Domain.Entity.studentEntity> GetOrder(Guid id)
            {
                throw new NotImplementedException();
            }

            public Task UpdateOrders(Domain.Entity.studentEntity studentEntity)
            {
                throw new NotImplementedException();
            }

        public Task UpdateOrder(studentEntity order)
        {
            throw new NotImplementedException();
        }

        Task<List<studentEntity>> IStudentService.GetByUser(string user)
        {
            throw new NotImplementedException();
        }

        Task<studentEntity> IStudentService.GetOrder(Guid id)
        {
            throw new NotImplementedException();
        }
    }
    }

