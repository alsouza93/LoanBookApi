using System.ComponentModel.DataAnnotations;

namespace LoanBook.Api.Models
{
    public class RequestBookModel
    {
        [Required(ErrorMessage = "This field {0} is required")]
        [StringLength(200, ErrorMessage = "This field {0} needs to be between {2} and {1} characters", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field {0} is required")]
        [StringLength(200, ErrorMessage = "This field {0} needs to be between {2} and {1} characters", MinimumLength = 2)]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field {0} is required")]
        [StringLength(200, ErrorMessage = "This field {0} needs to be between {2} and {1} characters", MinimumLength = 2)]
        public string Isbn { get; set; }

        public int AvailableQuantity { get; set; }
    }
}
