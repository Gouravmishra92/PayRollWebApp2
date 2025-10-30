using PayrollWebApp.Models;
using PayrollWebApp.Utils;

namespace PayrollWebApp.Services
{
    public class PayrollService
    {
        private readonly string _filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "payroll.json");
        private List<SalaryRecord> _records;

        public PayrollService()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(_filePath)!);
            _records = FileHelper.LoadFromFile<List<SalaryRecord>>(_filePath) ?? new List<SalaryRecord>();
        }

        public List<SalaryRecord> GetAllRecords()
        {
            return _records;
        }

        public SalaryRecord? GetByEmployeeId(int empId)
        {
            return _records.FirstOrDefault(r => r.EmployeeId == empId);
        }

        public void AddRecord(SalaryRecord record)
        {
            record.Id = _records.Count > 0 ? _records.Max(r => r.Id) + 1 : 1;
            _records.Add(record);
            FileHelper.SaveToFile(_filePath, _records);
        }
    }
}
