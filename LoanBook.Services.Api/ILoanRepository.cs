using LoanBook.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanBook.Services.Api
{
    public interface ILoanRepository
    {
        Loan FindBy(Guid Id);       
        List<Loan> FindByBook(Guid bookId);
        List<Loan> FindByStudent(Guid studentId);
        Loan Create(Loan loan);
        void Remove(Guid Id);
        Loan ReturnBook(Guid Id);
    }
}