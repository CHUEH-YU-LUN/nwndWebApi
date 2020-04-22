using NwndWebApi.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.DAL
{
    public interface IEmployeesDAO
    {
        IEnumerable<Employees> GetEmployees();
        void CreateEmployees(Employees customers);
        void UpdateEmployees(Employees customers);
        void DeleteEmployees(int id);
    }
}
