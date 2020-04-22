using NwndWebApi.Factory;
using NwndWebApi.Models.DTO;
using NwndWebApi.Repository.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Models.DAL
{
    [DependencyRegister]
    public class EmployeesDAO : IEmployeesDAO
    {
        private readonly NorthwindContext _context;

        public EmployeesDAO(NorthwindContext context)
        {
            _context = context;
        }

        public void CreateEmployees(Employees employees)
        {
            try
            {
                _context.Employees.Add(employees);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteEmployees(int id)
        {
            try
            {
                var _Employees = _context.Employees.Find(id);
                _context.Employees.Remove(_Employees);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public IEnumerable<Employees> GetEmployees()
        {
            try
            {
                IEnumerable<Employees> _Employees = from x in _context.Employees select x;

                return _Employees;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateEmployees(Employees employees)
        {
            try
            {
                _context.Employees.Update(employees);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
