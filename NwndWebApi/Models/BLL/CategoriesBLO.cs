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
    public class CategoriesBLO : ICategoriesBLO
    {
        private ICategoriesDAO iCategoriesDAO;

        public CategoriesBLO(ICategoriesDAO _iCategoriesDAO)
        {
            iCategoriesDAO = _iCategoriesDAO;
        }

        public void CreateCategories(inCategories inCategories)
        {
            try
            {
                Categories categories = new Categories()
                {
                    CategoryId = inCategories.CategoryID,
                    CategoryName = inCategories.CategoryName,
                    Description = inCategories.Desc,
                    Picture = inCategories.Picture
                };
                iCategoriesDAO.CreateCategories(categories);
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
                iCategoriesDAO.DeleteCategories(id);
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
                IEnumerable<Categories> _Categories = iCategoriesDAO.GetCategories();

                return _Categories;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateCategories(inCategories inCategories)
        {
            try
            {
                Categories categories = new Categories()
                {
                    CategoryId = inCategories.CategoryID,
                    CategoryName = inCategories.CategoryName,
                    Description = inCategories.Desc,
                    Picture = inCategories.Picture
                };
                iCategoriesDAO.UpdateCategories(categories);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
