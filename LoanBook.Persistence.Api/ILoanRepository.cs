using LoanBook.Domains;

namespace LoanBook.Persistence.Api
{
    public interface ILoanRepository
    {
        Loan Create(Loan loan);
    }
}