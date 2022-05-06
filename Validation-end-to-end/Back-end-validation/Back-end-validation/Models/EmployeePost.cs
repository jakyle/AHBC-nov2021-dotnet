using System;
using System.ComponentModel.DataAnnotations;

namespace Back_end_validation.Models
{
    public class EmployeePost
    {
        [Required]
        [Range(18, 75)]
        public int Age { get; set; }

        [Required]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        [Url]
        public string website { get; set; }
    }
}
