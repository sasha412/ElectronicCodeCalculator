using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebResistanceCalculator;
using WebResistanceCalculator.Controllers;
using ColorCodeCalculator;

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

    }
}
