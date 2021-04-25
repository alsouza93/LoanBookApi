using LoanBook.Domains;
using LoanBook.Persistence.Api;
using LoanBook.Services.Api;
using System;
using System.Collections.Generic;

namespace LoanBook.Services
{
    public class LoanService : ILoanService
    {
        private const int returnDate = 7;
        private readonly ILoanRepository loanRepository;
        public LoanService(ILoanRepository loanRepository)
        {
            this.loanRepository = loanRepository;
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
            if (book.AvailableQuantity == 0)
            {
                throw new InvalidOperationException("Book unavailable.");
            }

            var dueDate = DateTime.Now;
            var loan = new Loan(new Guid(), book, student, dueDate, dueDate.AddDays(returnDate));
            return loanRepository.Create(loan);          
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
