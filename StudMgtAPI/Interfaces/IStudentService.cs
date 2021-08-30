using StudMgtAPI.Dtos;
using Studmgt.Domain.Model;

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
