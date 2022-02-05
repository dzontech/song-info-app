using System;
using DataAccessLayer;
using DataAccessLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryLayerTests
{
    [TestClass]
    public class PerformerRepositoryTest
    {
        PerformerRepository performer;
        Performer perf;
        [TestInitialize]
        public void SetData()
        {
            performer = PerformerRepository.Instance;

            // Arrange
            perf = new Performer()
            {
                Performer_Id = 156,
                Name = "Bajaga",
                Surname = "Konstruktor"
            };
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }
        [TestMethod]
        public void InsertPerfomer()
        {
            // Act
            int result = this.performer.InsertPerfomer(perf.Name,perf.Surname);
            // Assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void UpdatePerfomer()
        {
            // Act
            int result = this.performer.UpdatePerformer(perf);
            // Assert
            Assert.AreEqual(1, result);
        } 
        [TestMethod]
        public void GetPerfomer()
        {
            // Act
            var result = this.performer.GetPerformer(perf.Name, perf.Surname);
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
