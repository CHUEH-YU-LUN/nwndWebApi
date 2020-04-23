using NwndWebApi.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.DAL
{
    public interface ICategoriesDAO
    {
        IEnumerable<Categories> GetCategories();
        void CreateCategories(Categories categories);
        void UpdateCategories(Categories categories);
        void DeleteCategories(int id);
        int GetCategoryID(string CategoriesName);
    }
}
