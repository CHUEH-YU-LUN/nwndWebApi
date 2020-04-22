using NwndWebApi.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.DAL
{
    public interface IProductsDAO
    {
        IEnumerable<Products> GetProducts();
        void CreateProducts(Products products);
        void UpdateProducts(Products products);
        void DeleteProducts(int id);
    }
}
