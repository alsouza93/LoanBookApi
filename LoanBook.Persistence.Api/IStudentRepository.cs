using LoanBook.Domains;
using System;
using System.Collections.Generic;

namespace LoanBook.Persistence.Api
{
    public interface IStudentRepository
    {
        Student FindBy(Guid Id);
        Student FindBy(string name);
        List<Student> FindaAll();
        Student Create(Student student);
        void Remove(Guid Id);
    }
}