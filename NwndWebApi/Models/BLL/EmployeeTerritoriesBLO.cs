using NwndWebApi.Factory;
using NwndWebApi.Models.DTO;
using NwndWebApi.Repository.BLL;
using NwndWebApi.Repository.DAL;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Models.BLL
{
    [DependencyRegister]
    public class EmployeeTerritoriesBLO : IEmployeeTerritoriesBLO
    {
        private IEmployeeTerritoriesDAO iEmployeeTerritoriesDAO;

        public EmployeeTerritoriesBLO(IEmployeeTerritoriesDAO _iEmployeeTerritoriesDAO)
        {
            iEmployeeTerritoriesDAO = _iEmployeeTerritoriesDAO;
        }

        public void CreateEmployeeTerritories(inEmployeeTerritories inEmployeeTerritories)
        {
            try
            {
                EmployeeTerritories employeeTerritories = new EmployeeTerritories()
                {
                    EmployeeId = inEmployeeTerritories.EmployeeId,
                    TerritoryId = inEmployeeTerritories.TerritoryId
                };
                iEmployeeTerritoriesDAO.CreateEmployeeTerritories(employeeTerritories);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteEmployeeTerritories(int EmployeeID,string TerritoryID)
        {
            try
            {
                iEmployeeTerritoriesDAO.DeleteEmployeeTerritories(EmployeeID,TerritoryID);
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
                IEnumerable<EmployeeTerritories> _EmployeeTerritories = iEmployeeTerritoriesDAO.GetEmployeeTerritories();

                return _EmployeeTerritories;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateEmployeeTerritories(inEmployeeTerritories inEmployeeTerritories)
        {
            try
            {
                EmployeeTerritories employeeTerritories = new EmployeeTerritories()
                {
                    EmployeeId = inEmployeeTerritories.EmployeeId,
                    TerritoryId = inEmployeeTerritories.TerritoryId
                };
                iEmployeeTerritoriesDAO.UpdateEmployeeTerritories(employeeTerritories);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
