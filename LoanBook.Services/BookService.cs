using LoanBook.Domains;
using LoanBook.Persistence.Api;
using LoanBook.Services.Api;
using System;
using System.Collections.Generic;

namespace LoanBook.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public Book Create(Book book)
        {
            return bookRepository.Create(book);
        }

        public List<Book> FindAll()
        {
            return bookRepository.Find();
        }

        public Book FindBy(Guid idBook)
        {
            return bookRepository.FindBy(idBook);
        }

        public Book FindBy(string name)
        {
            return bookRepository.FindBy(name);
        }

        public void Remove(Guid id)
        {
            bookRepository.Remove(id);
        }
    }
}