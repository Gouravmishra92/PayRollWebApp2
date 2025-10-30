using Microsoft.AspNetCore.Mvc;
using PayrollWebApp.Models;
using PayrollWebApp.Services;

namespace PayrollWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        // ✅ List all employees
        public IActionResult Index()
        {
            var employees = _employeeService.GetAll();
            return View(employees);
        }

        // ✅ View details of an employee
        public IActionResult Details(int id)
        {
            var employee = _employeeService.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // ✅ Add new employee (GET)
        public IActionResult Create()
        {
            return View();
        }

        // ✅ Add new employee (POST)
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Add(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // ✅ Edit employee (GET)
        public IActionResult Edit(int id)
        {
            var employee = _employeeService.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // ✅ Edit employee (POST)
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Update(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // ✅ Delete employee
        public IActionResult Delete(int id)
        {
            _employeeService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
