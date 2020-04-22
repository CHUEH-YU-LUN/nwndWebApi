using NwndWebApi.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.DAL
{
    public interface ISuppliersDAO
    {
        IEnumerable<Suppliers> GetSuppliers();
        void CreateSuppliers(Suppliers suppliers);
        void UpdateSuppliers(Suppliers suppliers);
        void DeleteSuppliers(int id);
    }
}
