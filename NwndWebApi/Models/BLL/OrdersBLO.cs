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
    public class OrdersBLO : IOrdersBLO
    {
        private IOrdersDAO iOrdersDAO;

        public OrdersBLO(IOrdersDAO _iOrdersDAO)
        {
            iOrdersDAO = _iOrdersDAO;
        }

        public void CreateOrders(inOrders inOrders)
        {
            try
            {
                Orders orders = new Orders()
                {
                    OrderId = inOrders.OrderId,
                    CustomerId = inOrders.CustomerId,
                    EmployeeId = inOrders.EmployeeId,
                    OrderDate = inOrders.OrderDate,
                    RequiredDate = inOrders.RequiredDate,
                    ShippedDate = inOrders.ShippedDate,
                    ShipVia = inOrders.ShipVia,
                    Freight = inOrders.Freight,
                    ShipName = inOrders.ShipName,
                    ShipAddress = inOrders.ShipAddress,
                    ShipCity = inOrders.ShipCity,
                    ShipRegion = inOrders.ShipRegion,
                    ShipPostalCode = inOrders.ShipPostalCode,
                    ShipCountry = inOrders.ShipCountry
                };
                iOrdersDAO.CreateOrders(orders);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteOrders(int id)
        {
            try
            {
                iOrdersDAO.DeleteOrders(id);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public IEnumerable<Orders> GetOrders()
        {
            try
            {
                IEnumerable<Orders> _Orders = iOrdersDAO.GetOrders();

                return _Orders;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateOrders(inOrders inOrders)
        {
            try
            {
                Orders orders = new Orders()
                {
                    OrderId = inOrders.OrderId,
                    CustomerId = inOrders.CustomerId,
                    EmployeeId = inOrders.EmployeeId,
                    OrderDate = inOrders.OrderDate,
                    RequiredDate = inOrders.RequiredDate,
                    ShippedDate = inOrders.ShippedDate,
                    ShipVia = inOrders.ShipVia,
                    Freight = inOrders.Freight,
                    ShipName = inOrders.ShipName,
                    ShipAddress = inOrders.ShipAddress,
                    ShipCity = inOrders.ShipCity,
                    ShipRegion = inOrders.ShipRegion,
                    ShipPostalCode = inOrders.ShipPostalCode,
                    ShipCountry = inOrders.ShipCountry
                };
                iOrdersDAO.UpdateOrders(orders);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
