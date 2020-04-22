using NwndWebApi.Models.DTO;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.BLL
{
    public interface ISuppliersBLO
    {
        IEnumerable<Suppliers> GetSuppliers();
        void CreateSuppliers(inSuppliers inSuppliers);
        void UpdateSuppliers(inSuppliers inSuppliers);
        void DeleteSuppliers(int id);
    }
}
