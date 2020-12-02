using System;

namespace LoanBook.Domains
{
    public class Student
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string DocumentNumber { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public Student(Guid id, string name, string documentNumber, DateTime dateOfBirth)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Student name is required");
            }
            if (string.IsNullOrWhiteSpace(documentNumber))
            {
                throw new ArgumentException("Student document number is required");
            }
            Id = id;
            Name = name;
            DocumentNumber = documentNumber;
            DateOfBirth = dateOfBirth;
        }
    }
}