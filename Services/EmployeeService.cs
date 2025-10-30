using PayrollWebApp.Models;
using PayrollWebApp.Utils;

namespace PayrollWebApp.Services
{
    public class EmployeeService
    {
        private readonly string _filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "employees.json");
        private List<Employee> _employees;

        public EmployeeService()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(_filePath)!);
            _employees = FileHelper.LoadFromFile<List<Employee>>(_filePath) ?? new List<Employee>();
        }

        public List<Employee> GetAll()
        {
            return _employees;
        }

        public Employee? GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public void Add(Employee emp)
        {
            emp.Id = _employees.Count > 0 ? _employees.Max(e => e.Id) + 1 : 1;
            _employees.Add(emp);
            FileHelper.SaveToFile(_filePath, _employees);
        }

        public void Update(Employee emp)
        {
            var existing = _employees.FirstOrDefault(e => e.Id == emp.Id);
            if (existing != null)
            {
                existing.Name = emp.Name;
                existing.Department = emp.Department;
                existing.Designation = emp.Designation;
                existing.BasicSalary = emp.BasicSalary;
                existing.Allowances = emp.Allowances;
                existing.Deductions = emp.Deductions;
                FileHelper.SaveToFile(_filePath, _employees);
            }
        }

        public void Delete(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                _employees.Remove(emp);
                FileHelper.SaveToFile(_filePath, _employees);
            }
        }
    }
}
