using LoanBook.Domains;
using System;

namespace LoanBook.Persistence.Api
{
    public interface IStudentRepository
    {
        Student FindBy(Guid Id);
        Student FindBy(string name);
        Student Create(Book book);
        void Remove(Guid Id);
    }
}