using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanBook.Services.Api;
using Microsoft.AspNetCore.Http;
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

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

       

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpGet("{id}")]
        public string Get(int idStudent)
        {
            return "value";
        }
    }
}