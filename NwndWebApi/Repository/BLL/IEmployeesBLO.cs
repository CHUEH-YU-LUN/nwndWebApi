using NwndWebApi.Models.DTO;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.BLL
{
    public interface IEmployeesBLO
    {
        IEnumerable<Employees> GetEmployees();
        void CreateEmployees(inEmployees inEmployees);
        void UpdateEmployees(inEmployees inEmployees);
        void DeleteEmployees(int id);
    }
}
