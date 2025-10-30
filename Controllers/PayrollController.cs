using Microsoft.AspNetCore.Mvc;
using PayrollWebApp.Models;
using PayrollWebApp.Services;

namespace PayrollWebApp.Controllers
{
    public class PayrollController : Controller
    {
        private readonly EmployeeService _employeeService;
        private readonly PayrollService _payrollService;

        public PayrollController()
        {
            _employeeService = new EmployeeService();
            _payrollService = new PayrollService();
        }

        // Payroll dashboard
        public IActionResult Index()
        {
            var records = _payrollService.GetAllRecords();
            return View(records);
        }

        // Generate payslip for a specific employee
        public IActionResult GeneratePayslip(int id)
        {
            var employee = _employeeService.GetById(id);
            if (employee == null)
                return NotFound();

            var record = new SalaryRecord
            {
                EmployeeId = employee.Id,
                EmployeeName = employee.Name,
                Department = employee.Department,
                Designation = employee.Designation,
                BasicSalary = employee.BasicSalary,
                Allowances = employee.Allowances,
                Deductions = employee.Deductions,
                Month = DateTime.Now.ToString("MMMM yyyy"),
                NetSalary = employee.BasicSalary + employee.Allowances - employee.Deductions
            };

            _payrollService.AddRecord(record);

            // Redirect to payslip view
            return RedirectToAction("Payslip", new { id = record.EmployeeId });
        }

        // Payslip view
        public IActionResult Payslip(int id)
        {
            var record = _payrollService.GetByEmployeeId(id);
            if (record == null)
                return NotFound();

            return View(record);
        }
    }
}
