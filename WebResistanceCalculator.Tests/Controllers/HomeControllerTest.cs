using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebResistanceCalculator;
using WebResistanceCalculator.Controllers;
using ColorCodeCalculator;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;

namespace WebResistanceCalculator.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ZeroBandResistorTest()
        {
            Exception exceptionResult = null;

            try
            {    // Arrange 
                IOhmValueCalculator ohmValueCalculator = new ResistanceCalculator();

                // Act
                ohmValueCalculator.CalculateOhmValue(null, null, null, null);
            }
            catch (Exception exception)
            {
                exceptionResult = exception;
            }

            // Assert
            Assert.IsNotNull(exceptionResult);
            Assert.IsInstanceOfType(exceptionResult, typeof(ArgumentException));
        }


        [TestMethod]
        public void TestFourBandResistor()
        {
            //Arrange
            IOhmValueCalculator ohmValueCalculator = new ResistanceCalculator();

            //Act
            ColorCodeResult result = ohmValueCalculator.CalculateOhmValue("yellow", "violet", "red", "gold");

            //Assert
            Assert.AreEqual("4935", result.MaximumResistance);
        }

        [TestMethod]
        public void TestLargeResistance()
        {
            //Arrange
            IOhmValueCalculator ohmValueCalculator = new ResistanceCalculator();

            //Act
            ColorCodeResult result = ohmValueCalculator.CalculateOhmValue("white", "white", "white", "silver");

            //Assert
            Assert.AreEqual("108,900M", result.MaximumResistance);
        }

        [TestMethod]
        public void TestSmallResistance()
        {
            //Arrange
            IOhmValueCalculator ohmValueCalculator = new ResistanceCalculator();

            //Act
            ColorCodeResult result = ohmValueCalculator.CalculateOhmValue("brown", "black", "black", "brown");

            //Assert
            Assert.AreEqual("10.1", result.MaximumResistance);
        }

        [TestMethod]
        public void TestArgumentNullException()
        {
            //Arrange
            HomeController hController = new HomeController();

            //Act
            JsonResult result = (JsonResult)hController.getResistanceValue(null,null,null,null);
            //convert JSON to string
            string stringResult = new JavaScriptSerializer().Serialize(result.Data);
            //parse json string
            JObject joResponse = JObject.Parse(stringResult);
            //get error
            string error = (string)joResponse["error"];

            //Assert
            Assert.AreEqual("Exception ocurred while calculating resistance value: Value cannot be null.\r\nParameter name: key", error);
        }

    }
}
