using System;
using LoanBook.Api.Models;
using LoanBook.Domains;
using LoanBook.Services.Api;
using Microsoft.AspNetCore.Mvc;

namespace LoanBook.Api.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;
        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = bookService.FindAll();
            return Ok(result);
        }

        [HttpGet("/{idBook}")]
        public IActionResult Get(string idBook)
        {
            var result = bookService.FindBy(new Guid(idBook));
            return Ok(result);
        }


        [HttpPost]
        public IActionResult Post([FromBody] RequestBookModel requestBookModel)
        {
            var book = bookService.Create(new Book(new Guid(),
                requestBookModel.Name,
                requestBookModel.Description,
                requestBookModel.Isbn,
                requestBookModel.AvailableQuantity));

            return Created($"/books/{book.Id}", book);
        }


        [HttpDelete("/{idBook}")]
        public IActionResult Delete(string idBook)
        {
            bookService.Remove(new Guid(idBook));
            return NoContent();
        }
    }
}