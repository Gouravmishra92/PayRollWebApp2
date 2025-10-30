using System.ComponentModel.DataAnnotations;

namespace PayrollWebApp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee name is required")]
        [Display(Name = "Full Name")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Department")]
        public string Department { get; set; } = string.Empty;

        [Required(ErrorMessage = "Designation is required")]
        [Display(Name = "Designation / Role")]
        public string Designation { get; set; } = string.Empty;

        // ✅ Salary-related properties
        [Required(ErrorMessage = "Basic Salary is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Salary must be a positive number")]
        [Display(Name = "Basic Salary (₹)")]
        public decimal BasicSalary { get; set; }

        [Display(Name = "Allowances (₹)")]
        [Range(0, double.MaxValue, ErrorMessage = "Allowances must be a positive number")]
        public decimal Allowances { get; set; }

        [Display(Name = "Deductions (₹)")]
        [Range(0, double.MaxValue, ErrorMessage = "Deductions must be a positive number")]
        public decimal Deductions { get; set; }

        // ✅ Computed property (not editable by user)
        [Display(Name = "Net Salary (₹)")]
        public decimal NetSalary => BasicSalary + Allowances - Deductions;

        // ✅ Optional: date when employee was added
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; } = DateTime.Now;
    }
}
