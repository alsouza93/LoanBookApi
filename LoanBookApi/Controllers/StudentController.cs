using System;
using LoanBook.Api.Models;
using LoanBook.Domains;
using LoanBook.Services.Api;
using Microsoft.AspNetCore.Mvc;

namespace LoanBook.Api.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] RequestStudentModel studentRequest)
        {
            var student = new Student(
                new Guid(),
                studentRequest.Name,
                studentRequest.DocumentNumber,
                DateTime.Parse(studentRequest.DateOfBirth));

            var result = studentService.Create(student);         
            return Created($"students/{result.Id}", result);
        }

        [HttpDelete("/{idStudent}")]
        public IActionResult Delete(string idStudent)
        {
            studentService.Remove(new Guid(idStudent));
            return NoContent();
        }

        [HttpGet("/{idStudent}")]
        public IActionResult Get(string idStudent)
        {
            var result = studentService.FindBy(new Guid(idStudent));
            return Ok(result);
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            var result = studentService.FindAll();
            return Ok(result);
        }
    }
}