using EntityFrameworkAssignment.Model;
using EntityFrameworkAssignment.StudentContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkAssignment.Repository_Layer
{
    public class StudentRepository : IStudentRepository
    {
        private StudentDbContext _studentContext;
        public StudentRepository(StudentDbContext studentContext)
        {
            _studentContext = studentContext; 
        }

        public Student AddStudent(Student student)
        {
            student.id = Guid.NewGuid();
            _studentContext.Students.Add(student);
            _studentContext.SaveChanges(); 
            return student; 
        }

        public void DeleteStudent(Student student)
        {
            _studentContext.Students.Remove(student);
            _studentContext.SaveChanges();
        }

        public Student EditStudent(Student student)
        { 
            var currentStudent = _studentContext.Students.Find(student.id);
            currentStudent.name = student.name;
            _studentContext.Update(currentStudent);
            _studentContext.SaveChanges();
            return currentStudent; 
        }

        public Student GetStudent(Guid id)
        {
            var student = _studentContext.Students.Find(id);
            if (student != null)
            {
                return student; 
            }
            return null; 
        }

        public List<Student> GetStudents()
        {
            return _studentContext.Students.ToList(); 
        }
    }
}
