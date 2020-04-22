using NwndWebApi.Models.DTO;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.BLL
{
    public interface IProductsBLO
    {
        IEnumerable<Products> GetProducts();
        void CreateProducts(inProducts inProducts);
        void UpdateProducts(inProducts inProducts);
        void DeleteProducts(int id);
    }
}
