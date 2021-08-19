using StudMgtAPI.Dtos;
using StudMgtAPI.Interfaces;
using StudMgtAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudMgtAPI.Services
{
    public class StudentServices: IStudentService
    {
        private readonly List<Student> _student;

        public StudentServices()
        {
            _student = new List<Student>();
            _student.AddRange
                (
                  new List<Student>
                  {
                     new Student
                     {
                         Guid=1,
                         name = "Nathan",
                         adress="6 Kilo",
                         department="CS"
                     },
                     new Student
                     {
                         Guid=2,
                         name = "Biruk",
                         adress="5 Kilo",
                         department="PM"
                     },
                     new Student
                     {
                         Guid=3,
                         name = "Kebede",
                         adress="4 Kilo",
                         department="APP"
                     }
                  }
                );
        }
            public ResponseDto<Student> Create(Student student)
            {
                _student.Add(student);
                return new ResponseDto<Student>(_student.ToList(), true);
            }
            public ResponseDto<Student> Edit(Student student)
            {
                //variable naming
                Student toEdit = _student.Find(x => x.Guid == student.Guid);
                toEdit.Guid = student.Guid;
            toEdit.name = student.name;
            toEdit.department = student.department;
            toEdit.age = student.age;
            toEdit.adress = student.adress;
                return new ResponseDto<Student>(_student.ToList(), true);
            }
            public ResponseDto<Student> Remove(int? id)
            {
                _student.Remove(_student.Find(x => x.Guid == id));
                return new ResponseDto<Student>(_student.ToList(), true);
            }

            public ResponseDto<Student> Get(int? id)
            {
                return new ResponseDto<Student>(_student.ToList(), true);
            }
        }
    }

