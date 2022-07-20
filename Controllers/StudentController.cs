using EntityFrameworkAssignment.Model;
using EntityFrameworkAssignment.Repository_Layer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EntityFrameworkAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository; 
        }
        [HttpGet]
        [Route("/getAllStudents")]
        public IActionResult GetStudents()
        {
            return Ok(_studentRepository.GetStudents()); 
        
        }
        [HttpGet]
        [Route("/getStudent/{id}")]
        public IActionResult GetEmployee(Guid id)
        {
            var student = _studentRepository.GetStudent(id);
            if (student != null)
            {
                return Ok(student); 
            } 
            return NotFound($"Student with Id {id} was not found."); 
        }

        [HttpPost]
        [Route("/addStudent")]
        public IActionResult AddStudent(Student student)
        {
            var createdEmployee = _studentRepository.AddStudent(student);
            return Created(String.Format(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + student.id), student); 
        }

        [HttpDelete]
        [Route("deleteStudent/{id}")] 
        public IActionResult DeleteStudent(Guid id)
        {
            var student = _studentRepository.GetStudent(id);
            if (student != null)
            {
                _studentRepository.DeleteStudent(student);
                return Ok("Student record deleted sucessfully " +
                    "");
            } 
            return NotFound($"Student with Id {id} was not found."); 
        }

        [HttpPatch]
        [Route("/updateStudent/{id}")] 
        public IActionResult EditStudent(Guid id, Student student)
        {
            var currentStudent = _studentRepository.GetStudent(id);
            if (currentStudent != null) 
            {
                student.id = id;
                _studentRepository.EditStudent(student);
                return Ok();
            }
            return NotFound($"Student with Id {student.id} was not found."); 
        }
    }
}
