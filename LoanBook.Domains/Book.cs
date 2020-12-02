using System;

namespace LoanBook.Domains
{
    public class Book
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Isbn { get; private set; }
        public int Quantity { get; private set; }
        public int AvailableQuantity { get; private set; }
        public Book(Guid id, string name, string description, string isbn, int quantity)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Book name is required");
            }
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Book description is required");
            }
            if (string.IsNullOrWhiteSpace(isbn))
            {
                throw new ArgumentException("Book ISBN is required");
            }

            Id = id;
            Name = name;
            Description = description;
            Isbn = isbn;
            Quantity = quantity;
        }
    }
}