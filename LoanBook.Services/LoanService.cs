using LoanBook.Domains;
using LoanBook.Services.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanBook.Services
{
    public class LoanService : ILoanService
    {
        public LoanService()
        {

        }

        public Loan FindBy(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<Loan> FindByBook(Guid idBook)
        {
            throw new NotImplementedException();
        }

        public List<Loan> FindByStudent(Guid idStudent)
        {
            throw new NotImplementedException();
        }

        public Loan LoanBook(Student student, Book book)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Loan ReturnBook(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
