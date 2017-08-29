using Jay.Db;
using Jay.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay.Manager.DataManager
{
    public class EmployeeManager
    {
        public void AddEmployee(Employee Employee)
        {
            using (var data = new MyDbContext())
            {
                data.Employees.Add(Employee);
                data.SaveChanges();
            }
        }

        public void AddEmployees(List<Employee> Employees)
        {
            using (var data = new MyDbContext())
            {
                data.Employees.AddRange(Employees);
                data.SaveChanges();
            }
        }

        public Employee GetEmployeeById(long employeeId)
        {
            using (var data = new MyDbContext())
            {
                return data.Employees.FirstOrDefault(x => x.EmployeeId == employeeId);                
            }
        }

        public List<Employee> GetAllEmployees(long employeeId)
        {
            using (var data = new MyDbContext())
            {
                return data.Employees.ToList();
                //return data.Employees.Where(x => x.Firstname == "").ToList();
            }
        }
    }
}
