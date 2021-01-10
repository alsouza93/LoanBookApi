using LoanBook.Domains;
using System;
using System.Collections.Generic;

namespace LoanBook.Services.Api
{
    public interface IStudentService
    {
        Student FindBy(Guid id);
        Student FindBy(string name);
        List<Student> FindAll();
        Student Create(Student student);
        void Remove(Guid id);
    }
}