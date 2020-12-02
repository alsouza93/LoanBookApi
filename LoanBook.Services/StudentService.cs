using LoanBook.Domains;
using LoanBook.Persistence.Api;
using LoanBook.Services.Api;
using System;

namespace LoanBook.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public Student Create(Book book)
        {
            throw new NotImplementedException();
        }

        public Student FindBy(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Student FindBy(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}