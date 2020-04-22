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
    public class EmployeesBLO : IEmployeesBLO
    {
        private IEmployeesDAO iEmployeesDAO;

        public EmployeesBLO(IEmployeesDAO _iEmployeesDAO)
        {
            iEmployeesDAO = _iEmployeesDAO;
        }

        public void CreateEmployees(inEmployees inEmployees)
        {
            try
            {
                Employees employees = new Employees()
                {
                    EmployeeId = inEmployees.EmployeeId,
                    LastName = inEmployees.LastName,
                    FirstName = inEmployees.FirstName,
                    Title = inEmployees.Title,
                    TitleOfCourtesy = inEmployees.TitleOfCourtesy,
                    BirthDate = inEmployees.BirthDate,
                    HireDate = inEmployees.HireDate,
                    Address = inEmployees.Address,
                    City = inEmployees.City,
                    Region = inEmployees.Region,
                    PostalCode = inEmployees.PostalCode,
                    Country = inEmployees.Country,
                    HomePhone = inEmployees.HomePhone,
                    Extension = inEmployees.Extension,
                    Photo = inEmployees.Photo,
                    Notes = inEmployees.Notes,
                    ReportsTo = inEmployees.ReportsTo,
                    PhotoPath = inEmployees.PhotoPath
                };
                iEmployeesDAO.CreateEmployees(employees);
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
                iEmployeesDAO.DeleteEmployees(id);
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
                IEnumerable<Employees> _Employees = iEmployeesDAO.GetEmployees();

                return _Employees;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateEmployees(inEmployees inEmployees)
        {
            try
            {
                Employees employees = new Employees()
                {
                    EmployeeId = inEmployees.EmployeeId,
                    LastName = inEmployees.LastName,
                    FirstName = inEmployees.FirstName,
                    Title = inEmployees.Title,
                    TitleOfCourtesy = inEmployees.TitleOfCourtesy,
                    BirthDate = inEmployees.BirthDate,
                    HireDate = inEmployees.HireDate,
                    Address = inEmployees.Address,
                    City = inEmployees.City,
                    Region = inEmployees.Region,
                    PostalCode = inEmployees.PostalCode,
                    Country = inEmployees.Country,
                    HomePhone = inEmployees.HomePhone,
                    Extension = inEmployees.Extension,
                    Photo = inEmployees.Photo,
                    Notes = inEmployees.Notes,
                    ReportsTo = inEmployees.ReportsTo,
                    PhotoPath = inEmployees.PhotoPath
                };
                iEmployeesDAO.UpdateEmployees(employees);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
