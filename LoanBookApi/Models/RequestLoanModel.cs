using System.ComponentModel.DataAnnotations;

namespace LoanBook.Api.Models
{
    public class RequestLoanModel
    {
        [Required(ErrorMessage = "This field {0} is required")]
        public string idStudent { get; set; }

        [Required(ErrorMessage = "This field {0} is required")]
        public string idBook { get; set; }

    }
}