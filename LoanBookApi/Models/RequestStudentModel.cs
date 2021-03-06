﻿using System.ComponentModel.DataAnnotations;

namespace LoanBook.Api.Models
{
    public class RequestStudentModel
    {

        [Required(ErrorMessage = "This field {0} is required")]
        [StringLength(200, ErrorMessage = "This field {0} needs to be between {2} and {1} characters", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field {0} is required")]
        [StringLength(50, ErrorMessage = "This field {0} needs to be between {2} and {1} characters", MinimumLength = 1)]
        public string DocumentNumber { get; set; }

        [Required(ErrorMessage = "This field {0} is required")]
        [DataType(DataType.Date, ErrorMessage = "This field {0} needs to be between {2} and {1} characters")]
        public string DateOfBirth { get; set; }
    }
}