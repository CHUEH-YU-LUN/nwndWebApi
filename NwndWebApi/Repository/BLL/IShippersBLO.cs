using NwndWebApi.Models.DTO;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.BLL
{
    public interface IShippersBLO
    {
        IEnumerable<Shippers> GetShippers();
        void CreateShippers(inShippers inShippers);
        void UpdateShippers(inShippers inShippers);
        void DeleteShippers(int id);
    }
}
