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
    public class ShippersBLO : IShippersBLO
    {
        private IShippersDAO iShippersDAO;

        public ShippersBLO(IShippersDAO _iShippersDAO)
        {
            iShippersDAO = _iShippersDAO;
        }

        public void CreateShippers(inShippers inShippers)
        {
            try
            {
                Shippers shippers = new Shippers()
                {
                    ShipperId = inShippers.ShipperId,
                    CompanyName = inShippers.CompanyName,
                    Phone = inShippers.Phone
                };
                iShippersDAO.CreateShippers(shippers);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteShippers(int id)
        {
            try
            {
                iShippersDAO.DeleteShippers(id);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public IEnumerable<Shippers> GetShippers()
        {
            try
            {
                IEnumerable<Shippers> _Shippers = iShippersDAO.GetShippers();

                return _Shippers;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateShippers(inShippers inShippers)
        {
            try
            {
                Shippers shippers = new Shippers()
                {
                    ShipperId = inShippers.ShipperId,
                    CompanyName = inShippers.CompanyName,
                    Phone = inShippers.Phone
                };
                iShippersDAO.UpdateShippers(shippers);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
