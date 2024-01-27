using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLib
{
    public class EmployeeRepository
    {
        private readonly BlogDbContext _context;

        public EmployeeRepository()
        {
            _context = new BlogDbContext();
        }

        public void SaveEmployee(EmpInfo employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<EmpInfo> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public bool ValidateEmployeeLogin(string email, int passCode)
        {
            return _context.Employees.Any(e => e.EmailId == email && e.PassCode == passCode);
        }
        public bool ValidateAdminLogin(string email, string password)
        {
            return _context.Admins.Any(a => a.EmailId == email && a.Password == password);
        }
    }
}
