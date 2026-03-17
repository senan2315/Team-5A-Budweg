using Microsoft.VisualStudio.TestTools.UnitTesting; 
using Budweg.Models;


namespace BudwegTest
{
    [TestClass]
    public class BrakeCaliperTests 
    {
        [TestMethod]
        public void Constructor_SetsCaliperId_Correctly()
        {
            var brakeCaliper = new BrakeCaliper(1);
            Assert.AreEqual(1, brakeCaliper.CaliperId);
        }

        [TestMethod]
        public void Properties_SetAndGetValues_Correctly()
        {
            // Arrange
            var brakeCaliper = new BrakeCaliper(2);

            // Act
            brakeCaliper.CaliperType = "TypeA";
            brakeCaliper.Barcode = "123456789";
            brakeCaliper.OrderNumber = "ORD-001";
            brakeCaliper.Note = "Requires inspection";

            // Assert
            Assert.AreEqual("TypeA", brakeCaliper.CaliperType);
            Assert.AreEqual("123456789", brakeCaliper.Barcode);
            Assert.AreEqual("ORD-001", brakeCaliper.OrderNumber);
            Assert.AreEqual("Requires inspection", brakeCaliper.Note);
        }
    }
}
