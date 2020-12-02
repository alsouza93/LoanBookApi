using LoanBook.Domains;
using System;

namespace LoanBook.Services.Api
{
    public interface IBookService
    {
        Book FindBy(Guid Id);
        Book FindBy(string name);
        Book Create(Book book);
        void Remove(Guid Id);
    }
}