using LoanBook.Domains;
using System;

namespace LoanBook.Services.Api
{
    public interface IStudentService
    {
        Student FindBy(Guid Id);
        Student FindBy(string name);
        Student Create(Book book);
        void Remove(Guid Id);
    }
}