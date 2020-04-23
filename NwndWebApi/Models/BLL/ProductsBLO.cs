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
    public class ProductsBLO : IProductsBLO
    {
        private IProductsDAO iProductsDAO;
        private ISuppliersDAO iSuppliersDAO;
        private ICategoriesDAO iCategoriesDAO;

        public ProductsBLO(IProductsDAO _iProductsDAO, ISuppliersDAO _iSuppliersDAO, ICategoriesDAO _iCategoriesDAO)
        {
            iProductsDAO = _iProductsDAO;
            iSuppliersDAO = _iSuppliersDAO;
            iCategoriesDAO = _iCategoriesDAO;
        }

        public void CreateProducts(inProducts inProducts)
        {
            try
            {
                Products products = new Products()
                {
                    ProductId = inProducts.ProductId,
                    ProductName = inProducts.ProductName,
                    SupplierId = iSuppliersDAO.GetSupplierID(inProducts.Supplier_CompanyName),
                    CategoryId = iCategoriesDAO.GetCategoryID(inProducts.CategoryName),
                    QuantityPerUnit = inProducts.QuantityPerUnit,
                    UnitPrice = inProducts.UnitPrice,
                    UnitsInStock = inProducts.UnitsInStock,
                    ReorderLevel = inProducts.ReorderLevel,
                    Discontinued = inProducts.Discontinued
                };
                iProductsDAO.CreateProducts(products);
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
                iProductsDAO.DeleteProducts(id);
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
                IEnumerable<Products> _Products = iProductsDAO.GetProducts();

                return _Products;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateProducts(inProducts inProducts)
        {
            try
            {
                Products products = new Products()
                {
                    ProductId = inProducts.ProductId,
                    ProductName = inProducts.ProductName,
                    SupplierId = iSuppliersDAO.GetSupplierID(inProducts.Supplier_CompanyName),
                    CategoryId = iCategoriesDAO.GetCategoryID(inProducts.CategoryName),
                    QuantityPerUnit = inProducts.QuantityPerUnit,
                    UnitPrice = inProducts.UnitPrice,
                    UnitsInStock = inProducts.UnitsInStock,
                    ReorderLevel = inProducts.ReorderLevel,
                    Discontinued = inProducts.Discontinued
                };
                iProductsDAO.UpdateProducts(products);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
