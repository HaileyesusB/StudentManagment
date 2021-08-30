using Microsoft.AspNetCore.Mvc;
using StudMgtAPI.Dtos;
using StudMgtAPI.Interfaces;
using Studmgt.Domain.Model;
namespace StudMgtAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        [HttpGet("GetAll")]
        public ResponseDto<Student> Get()
        {
            return _studentService.Get(null);

        }

        [HttpPost]
        public ResponseDto<Student> Add(Student student)
        {
            return _studentService.Create(student);

        }

        [HttpPut]
        public ResponseDto<Student> Edit(Student student)
        {
            return _studentService.Edit(student);
        }

        [HttpDelete]
        public ResponseDto<Student> Remove(int id)
        {
            return _studentService.Remove(null);
        }


    }

}

