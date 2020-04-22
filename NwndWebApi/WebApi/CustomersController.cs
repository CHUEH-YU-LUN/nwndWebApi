using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NwndWebApi.Repository.BLL;
using NwndWebApi.ViewModels.UniForm;

namespace NwndWebApi.WebApi
{
    [Route("api/[controller]/[action]")]
    public class CustomersController : Controller
    {
        private ICustomersBLO iCustomersBLO;

        public CustomersController(ICustomersBLO _iCustomersBLO)
        {
            iCustomersBLO = _iCustomersBLO;
        }


        [HttpGet]
        public outUniResult Get_Customers()
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = StatusCodes.Status200OK;
                _outUniResult.Result = iCustomersBLO.GetCustomers();
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
        public outUniResult Create_Customers([FromBody]inCustomers inCustomers)
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = StatusCodes.Status201Created;
                iCustomersBLO.CreateCustomers(inCustomers);
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
        public outUniResult Update_Customers([FromBody]inCustomers inCustomers)
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = StatusCodes.Status204NoContent;
                iCustomersBLO.UpdateCustomers(inCustomers);
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
        public outUniResult Delete_Customers([FromBody]inCustomers inCustomers)
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = StatusCodes.Status204NoContent;
                iCustomersBLO.DeleteCustomers(inCustomers.CustomerId);
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
