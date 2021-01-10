using LoanBook.Api.Models;
using LoanBook.Services.Api;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LoanBook.Api.Controllers
{
    [Route("api/loans")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly IStudentService studentService;
        private readonly IBookService bookService;
        private readonly ILoanService loanService;
        public LoanController(IStudentService studentService,
            IBookService bookService,
            ILoanService loanService)
        {
            this.studentService = studentService;
            this.bookService = bookService;
            this.loanService = loanService;
        }

        [HttpPost]
        public IActionResult LoanBook([FromBody] RequestLoanModel requestLoanModel)
        {
            var student = studentService.FindBy(new Guid(requestLoanModel.idStudent));
            if (student == null)
                return NotFound($"Student {requestLoanModel.idStudent} not found.");

            var book = bookService.FindBy(new Guid(requestLoanModel.idBook));
            if (book == null)
                return NotFound($"Book {requestLoanModel.idBook} not found.");

            var result = loanService.LoanBook(student, book);
            return Created($"loan/{result.Id}", result);
        }

        [HttpPost]
        public IActionResult ReturnBook([FromBody] RequestLoanModel requestLoanModel)
        {
            var student = studentService.FindBy(new Guid(requestLoanModel.idStudent));
            if (student == null)
                return NotFound($"Student {requestLoanModel.idStudent} not found.");

            var book = bookService.FindBy(new Guid(requestLoanModel.idBook));
            if (book == null)
                return NotFound($"Book {requestLoanModel.idBook} not found.");

            var result = loanService.LoanBook(student, book);
            return Created($"loan/{result.Id}", result);
        }
    }
}