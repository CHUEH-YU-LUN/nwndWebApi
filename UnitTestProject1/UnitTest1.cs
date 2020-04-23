using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NwndWebApi.Repository.BLL;
using NwndWebApi.WebApi;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var expected = StatusCodes.Status200OK;

            //Act
            var iShippersBLO = new Mock<IShippersBLO>();
            ShippersController controller = new ShippersController(iShippersBLO.Object);
            var actal = controller.Get_Shippers().StatusCode;
            

            //Assert
            Assert.AreEqual(expected, actal);
        }
    }
}
