using System.ComponentModel.DataAnnotations;

namespace EmployeePayroll_Ajax.Models
{
    public class EmployeeModel
    {
        [Key]

        public int Emp_Id { get; set; }
        [RegularExpression("[A-Z]{1}[a-z]{3,}", ErrorMessage = "Please Enter for Employee Name Atleast 3 character with first letter capital")]
        [Required]
        public string Name { get; set; }
        [Required (ErrorMessage = "Please Select Gender")]
        public string Gender { get; set; }
        [Required (ErrorMessage ="Please Select Department")]
        public string Department { get; set; }
        [Required (ErrorMessage ="Please Enter Notes")]
        public string Notes { get; set; }

    }
}
