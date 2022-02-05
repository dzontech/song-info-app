using BusinessLayer;
using DataAccessLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLayerTests
{
    [TestClass]
    public class BusinessPerformerTests
    {
        BusinessPerfomer business;

        
        [TestInitialize]
        public void SetData()
        {
            business = new BusinessPerfomer();

        }
        [TestMethod]
        public void CanInsertPerformer()
        {
            // Arrange
            var name = "Ivan";
            var surname = "Krstic";

            // Act
            int result = business.InsertPerformer(name, surname);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CanUpdatePerformer()
        {
            // Arrange
            Performer performer = new Performer()
            {
                Name = "Ivan",
                Surname = "Krstic",
                Performer_Id = 159
            };

            // Act
            var result = business.UpdatePerformer(performer);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetPerformer()
        {
            // Arrange
            var name = "John";
            var surname = "Doe";

            // Act
            var result = business.GetPerformer(name, surname);

            // Assert
            Assert.AreEqual(130, result.Performer_Id);
        }
    }
}
