using LoanBook.Domains;
using System;

namespace LoanBook.Persistence.Api
{
    public interface IBookRepository
    {
        Book FindBy(Guid Id);
        Book FindBy(string name);
        Book Create(Book book);
        void Remove(Guid Id);        
    }
}