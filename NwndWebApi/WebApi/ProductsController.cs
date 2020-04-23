using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NwndWebApi.Repository.BLL;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.WebApi
{
    [Route("api/[controller]/[action]")]
    public class ProductsController : Controller
    {
        private IProductsBLO iProductsBLO;

        public ProductsController(IProductsBLO _iProductsBLO)
        {
            iProductsBLO = _iProductsBLO;
        }

        [HttpGet]
        public outUniResult Get_Products()
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = StatusCodes.Status200OK;
                _outUniResult.Result = iProductsBLO.GetProducts();
                _outUniResult.Error = null;

                return _outUniResult;
            }
            catch (Exception e)
            {
                //throw new Exception();
                _outUniResult.StatusCode = StatusCodes.Status404NotFound;
                _outUniResult.Result = "發生錯誤了";
                _outUniResult.Error = null;
                return _outUniResult;
            }

        }

        [HttpPost]
        public outUniResult Create_Products([FromBody]inProducts inProducts)
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = StatusCodes.Status201Created;
                iProductsBLO.CreateProducts(inProducts);
                _outUniResult.Result = "succes";
                _outUniResult.Error = null;

                return _outUniResult;
            }
            catch (Exception e)
            {
                //throw new Exception();
                _outUniResult.StatusCode = StatusCodes.Status404NotFound;
                _outUniResult.Result = "發生錯誤了";
                _outUniResult.Error = null;
                return _outUniResult;
            }
        }

        [HttpPatch]
        public outUniResult Update_Products([FromBody]inProducts inProducts)
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = StatusCodes.Status204NoContent;
                iProductsBLO.UpdateProducts(inProducts);
                _outUniResult.Result = "succes";
                _outUniResult.Error = null;

                return _outUniResult;
            }
            catch (Exception e)
            {
                //throw new Exception();
                _outUniResult.StatusCode = StatusCodes.Status404NotFound;
                _outUniResult.Result = "發生錯誤了";
                _outUniResult.Error = null;
                return _outUniResult;
            }
        }

        [HttpDelete]
        public outUniResult Delete_Products([FromBody]inProducts inProducts)
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = StatusCodes.Status204NoContent;
                iProductsBLO.DeleteProducts(inProducts.ProductId);
                _outUniResult.Result = "succes";
                _outUniResult.Error = null;

                return _outUniResult;
            }
            catch (Exception e)
            {
                //throw new Exception();
                _outUniResult.StatusCode = StatusCodes.Status404NotFound;
                _outUniResult.Result = "發生錯誤了";
                _outUniResult.Error = null;
                return _outUniResult;
            }
        }
    }
}
