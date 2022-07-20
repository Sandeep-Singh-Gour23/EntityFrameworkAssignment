using EntityFrameworkAssignment.Model;
using System;
using System.Collections.Generic;

namespace EntityFrameworkAssignment.Repository_Layer
{
    public interface IStudentRepository
    {
        Student AddStudent(Student student);
        List<Student> GetStudents();
        Student GetStudent(Guid id);
        void DeleteStudent(Student student);
        Student EditStudent(Student student);
    }
}
