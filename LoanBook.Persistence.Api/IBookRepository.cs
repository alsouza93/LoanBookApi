using LoanBook.Domains;
using System;
using System.Collections.Generic;

namespace LoanBook.Persistence.Api
{
    public interface IBookRepository
    {
        Book FindBy(Guid Id);
        Book FindBy(string name);
        List<Book> Find();
        Book Create(Book book);
        void Remove(Guid Id);
    }
}