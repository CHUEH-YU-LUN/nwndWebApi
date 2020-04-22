using NwndWebApi.Models.DTO;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.BLL
{
    public interface IEmployeeTerritoriesBLO
    {
        IEnumerable<EmployeeTerritories> GetEmployeeTerritories();
        void CreateEmployeeTerritories(inEmployeeTerritories inEmployeeTerritories);
        void UpdateEmployeeTerritories(inEmployeeTerritories inEmployeeTerritories);
        void DeleteEmployeeTerritories(int EmployeeID,string TerritoryID);
    }
}
