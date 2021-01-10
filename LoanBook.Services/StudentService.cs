using LoanBook.Domains;
using LoanBook.Persistence.Api;
using LoanBook.Services.Api;
using System;
using System.Collections.Generic;

namespace LoanBook.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }   

        public Student Create(Student student)
        {
            return studentRepository.Create(student);
        }

        public List<Student> FindAll()
        {
            return studentRepository.FindaAll();
        }

        public Student FindBy(Guid id)
        {
            return studentRepository.FindBy(id);
        }

        public Student FindBy(string name)
        {
            return studentRepository.FindBy(name);
        }

        public void Remove(Guid id)
        {
            studentRepository.Remove(id);
        }
    }
}