using NwndWebApi.Models.DTO;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.BLL
{
    public interface ICategoriesBLO
    {
        IEnumerable<Categories> GetCategories();
        void CreateCategories(inCategories inCategories);
        void UpdateCategories(inCategories inCategories);
        void DeleteCategories(int id);
    }
}
