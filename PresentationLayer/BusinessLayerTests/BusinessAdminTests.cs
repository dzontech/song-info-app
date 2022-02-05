using BusinessLayer;
using DataAccessLayer;
using DataAccessLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLayerTests
{
    [TestClass]
    public class BusinessAdminTests
    {
        BusinessAdmin businessAdmin;
        Admin admin;

        [TestInitialize]
        public void SetData()
        {
            businessAdmin = new BusinessAdmin();
            admin = new Admin()
            {
                Admin_Id = 122,
                Name = "Ivan",
                Surname = "Jeftic",
                Username = "ivankrstic",
                Password = "Ikrstic123456"
            };

        }
    
        /*    [TestCleanup]
            public void TestCleanUp()
            {
                businessAdmin.DeleteAdmin(new Admin()
                {
                    Username = "ivankrstic"
                });
            }*/

        /*  // Admin is already inserted
          [TestMethod]
          public void IsAdminRegistered()
          {
              // Arrange
              admin = new Admin()
              {
                  Name = "Ivan",
                  Surname = "Krstic",
                  Username = "ivankrstic",
                  Password = "Ikrstic123456"
              };

              //Act
              var result = businessAdmin.RegisterAdmin(admin);

              //Assert

          }*/

        [TestMethod]
        public void CanAdminBeReturned_Situation_AdminExists()
        {
            // Arrange
            admin = new Admin()
            {
                Name = "Ivan",
                Surname = "Krstic",
                Username = "ivankrstic",
                Password = "Ikrstic123456"
            };
            // Act
            var result1 = businessAdmin.GetAdmin();
            //Assert
            Assert.IsTrue(result1);
        }

        [TestMethod]
        public void CanAdminBeAuthentificated()
        {
            // Arrange
            admin = new Admin()
            {
                Name = "Ivan",
                Surname = "Krstic",
                Username = "ivankrstic",
                Password = "Ikrstic123456"
            };

            // Act
            var result1 = businessAdmin.AuthenticateAdmin(admin);

            //Assert
            Assert.AreEqual(admin.Username, result1.Username);
        }

        [TestMethod]
        public void CanUserBeUpdated()
        {
            // Arrange
          
            // Act
            var result1 = businessAdmin.UpdateAdmin(admin);

            //Assert
            Assert.AreEqual(1, result1);
        }

        [TestMethod]
        public void IsValidPassword_True()
        {
            // Arrange
            var password = "IvanKrstic1234";
            // Act
            var result1 = businessAdmin.IsValidPassword(password);

            //Assert
            Assert.IsTrue(result1);
        }

        [TestMethod]
        public void IsValidPassword_False()
        {
            // Arrange
            var password = "ivankrstic";
            // Act
            var result1 = businessAdmin.IsValidPassword(password);

            //Assert
            Assert.IsFalse(result1);
        }

        [TestMethod]
        public void IsValidUsername_True()
        {
            // Arrange
            var username = "ivankrstic";
            // Act
            var result1 = businessAdmin.IsValidUsername(username);

            //Assert
            Assert.IsTrue(result1);
        }

        [TestMethod]
        public void IsValidUsername_False()
        {
            // Arrange
            var username = "ivan";
            // Act
            var result1 = businessAdmin.IsValidUsername(username);

            //Assert
            Assert.IsFalse(result1);
        }




    }
}
