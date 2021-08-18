using StudMgtAPI.Dtos;
using StudMgtAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudMgtAPI.Interfaces
{ 
  public  interface IStudentService
{
    public ResponseDto<Student> Get(int? id);

    public ResponseDto<Student> Create(Student student);

    public ResponseDto<Student> Edit(Student student);

    public ResponseDto<Student> Remove(int? id);
}
}
