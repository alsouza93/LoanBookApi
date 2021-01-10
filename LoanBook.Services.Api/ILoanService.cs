using LoanBook.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanBook.Services.Api
{
    public interface ILoanService
    {
        Loan FindBy(Guid Id);       
        List<Loan> FindByBook(Guid idBook);
        List<Loan> FindByStudent(Guid idStudent);
        Loan LoanBook(Student student, Book book);
        void Remove(Guid Id);
        Loan ReturnBook(Guid Id);
    }
}