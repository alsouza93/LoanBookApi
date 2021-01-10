using LoanBook.Domains;
using System;
using System.Collections.Generic;

namespace LoanBook.Services.Api
{
    public interface IBookService
    {
        Book FindBy(Guid id);
        List<Book> FindAll();
        Book FindBy(string name);
        Book Create(Book book);
        void Remove(Guid idBook);
    }
}