using NwndWebApi.Models.DTO;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.BLL
{
    public interface IOrdersBLO
    {
        IEnumerable<Orders> GetOrders();
        void CreateOrders(inOrders inOrders);
        void UpdateOrders(inOrders inOrders);
        void DeleteOrders(int id);
    }
}
