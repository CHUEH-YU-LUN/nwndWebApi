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
    public class ShippersController : Controller
    {
        private IShippersBLO iShippersBLO;

        public ShippersController(IShippersBLO _iShippersBLO)
        {
            iShippersBLO = _iShippersBLO;
        }


        [HttpGet]
        public outUniResult Get_Shippers()
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = StatusCodes.Status200OK;
                _outUniResult.Result = iShippersBLO.GetShippers();
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
        public outUniResult Create_Shippers([FromBody]inShippers inShippers)
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = StatusCodes.Status201Created;
                iShippersBLO.CreateShippers(inShippers);
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
        public outUniResult Update_Shippers([FromBody]inShippers inShippers)
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = StatusCodes.Status204NoContent;
                iShippersBLO.UpdateShippers(inShippers);
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
        public outUniResult Delete_Shippers([FromBody]inShippers inShippers)
        {
            outUniResult _outUniResult = new outUniResult();

            try
            {
                _outUniResult.StatusCode = StatusCodes.Status204NoContent;
                iShippersBLO.DeleteShippers(inShippers.ShipperId);
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
