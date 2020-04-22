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
    public class CategoriesDAO : ICategoriesDAO
    {
        private readonly NorthwindContext _context;

        public CategoriesDAO(NorthwindContext context)
        {
            _context = context;
        }

        public void CreateCategories(Categories categories)
        {
            try
            {
                _context.Categories.Add(categories);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteCategories(int id)
        {
            try
            {
                var _Categories = _context.Categories.Find(id);
                _context.Categories.Remove(_Categories);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public IEnumerable<Categories> GetCategories()
        {
            try
            {
                IEnumerable<Categories> _Categories = from x in _context.Categories select x;

                return _Categories;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateCategories(Categories categories)
        {
            try
            {
                _context.Categories.Update(categories);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
