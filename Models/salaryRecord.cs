namespace PayrollWebApp.Models
{
    public class SalaryRecord
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public string Month { get; set; } = string.Empty;

        public decimal BasicSalary { get; set; }
        public decimal Allowances { get; set; }
        public decimal Deductions { get; set; }

        public decimal NetSalary { get; set; }
    }
}
