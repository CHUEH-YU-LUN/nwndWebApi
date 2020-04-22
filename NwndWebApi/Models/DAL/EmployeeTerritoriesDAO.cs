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
    public class EmployeeTerritoriesDAO : IEmployeeTerritoriesDAO
    {
        private readonly NorthwindContext _context;

        public EmployeeTerritoriesDAO(NorthwindContext context)
        {
            _context = context;
        }

        public void CreateEmployeeTerritories(EmployeeTerritories employeeTerritories)
        {
            try
            {
                _context.EmployeeTerritories.Add(employeeTerritories);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteEmployeeTerritories(int EmployeeID,string TerritorID)
        {
            try
            {
                var _EmployeeTerritories = _context.EmployeeTerritories.Find(EmployeeID,TerritorID);
                _context.EmployeeTerritories.Remove(_EmployeeTerritories);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public IEnumerable<EmployeeTerritories> GetEmployeeTerritories()
        {
            try
            {
                IEnumerable<EmployeeTerritories> _EmployeeTerritories = from x in _context.EmployeeTerritories select x;

                return _EmployeeTerritories;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateEmployeeTerritories(EmployeeTerritories employeeTerritories)
        {
            try
            {
                _context.EmployeeTerritories.Update(employeeTerritories);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
