using System;

namespace LoanBook.Domains
{
    public class Loan
    {
        public Guid Id { get; private set; }
        public Book Book { get; private set; }
        public Student Student { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }
        public Loan(Guid id, Book book, Student student, DateTime dueDate, DateTime? returnDate)
        {
            Book = book ?? throw new ArgumentNullException("Book is required");
            Student = student ?? throw new ArgumentNullException("Student is required");
            Id = id;
            Book = book;
            Student = student;
            DueDate = dueDate;
            ReturnDate = returnDate;
        }
    }
}