using LoanBook.Domains;
using LoanBook.Persistence.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanBook.Persistence
{
    public class StudentRepository : IStudentRepository
    {
        public Student Create(Student student)
        {
            return student;
        }

        public List<Student> FindaAll()
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
