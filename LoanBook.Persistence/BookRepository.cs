﻿using LoanBook.Domains;
using LoanBook.Persistence.Api;
using System;
using System.Collections.Generic;

namespace LoanBook.Persistence
{
    public class BookRepository : IBookRepository
    {
        public Book Create(Book book)
        {
            throw new NotImplementedException();
        }

        public List<Book> Find()
        {
            throw new NotImplementedException();
        }

        public Book FindBy(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Book FindBy(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
