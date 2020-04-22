using NwndWebApi.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.DAL
{
    public interface IEmployeeTerritoriesDAO
    {
        IEnumerable<EmployeeTerritories> GetEmployeeTerritories();
        void CreateEmployeeTerritories(EmployeeTerritories employeeTerritories);
        void UpdateEmployeeTerritories(EmployeeTerritories employeeTerritories);
        void DeleteEmployeeTerritories(int EmployeeID,string TerritorID);
    }
}
