using System;

namespace LoanBook.Domains
{
    public class Student
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public SocialNumber SocialNumber { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public Email Email { get; private set; }
        public Cellphone Cellphone { get; private set; }
        public Student(Guid id, string name, SocialNumber socialNumber, DateTime dateOfBirth, Email email, Cellphone cellphone)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Student name is required");
            }

            SocialNumber = socialNumber ?? throw new ArgumentNullException("Student social number is required");
            Id = id;
            Name = name;           
            DateOfBirth = dateOfBirth;
            Email = email;
            Cellphone = cellphone;
        }
    }
}