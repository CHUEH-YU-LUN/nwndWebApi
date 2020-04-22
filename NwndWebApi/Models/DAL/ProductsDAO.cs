using NwndWebApi.Factory;
using NwndWebApi.Models.DTO;
using NwndWebApi.Repository.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Models.DAL
{
    [DependencyRegister]
    public class ProductsDAO : IProductsDAO
    {
        private readonly NorthwindContext _context;

        public ProductsDAO(NorthwindContext context)
        {
            _context = context;
        }

        public void CreateProducts(Products products)
        {
            try
            {
                _context.Products.Add(products);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteProducts(int id)
        {
            try
            {
                var _Products = _context.Products.Find(id);
                _context.Products.Remove(_Products);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public IEnumerable<Products> GetProducts()
        {
            try
            {
                IEnumerable<Products> _Products = from x in _context.Products select x;

                return _Products;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateProducts(Products products)
        {
            try
            {
                _context.Products.Update(products);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
