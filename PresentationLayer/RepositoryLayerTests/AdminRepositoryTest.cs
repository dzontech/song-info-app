using System;
using System.Collections.Generic;
using DataAccessLayer;
using DataAccessLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryLayerTests
{
    [TestClass]
    public class AdminRepositoryTest
    {
        AdminRepository admin;
        Admin adminFake;

        [TestInitialize]
        public void SetData()
        {
           admin = AdminRepository.Instance;
            // Arrange
           adminFake = new Admin()
            {
                Admin_Id = 119,
                Name = "Korisnik",
                Surname = "Korisnik1",
                Username = "adminadmin",
                Password = "Adminadmin1"
            };
        }
        [TestCleanup]
        public void TestCleanup()
        {
            this.admin.DeleteAdmin(
                new Admin() { Name = "adminadmin" });
        }
        
        [TestMethod]
        public void GetAdmin()
        {
            // Act
            List<Admin> list = this.admin.GetAdmin();
            // Assert
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void AuthentificationAdmin()
        {
            // Act
            Admin adm = this.admin.AuthenticateAdmin(adminFake);
            // Assert
            Assert.IsNotNull(adm);
        }
        [TestMethod]
        public void UpdateAdmin()
        {
            // Act
            int adm = this.admin.UpdateAdmin(this.adminFake);
            // Assert
            Assert.AreEqual(1, adm);
        }
    }
}
