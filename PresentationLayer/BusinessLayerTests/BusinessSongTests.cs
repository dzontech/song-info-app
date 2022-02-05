using BusinessLayer;
using DataAccessLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLayerTests
{
    [TestClass]
    public class BusinessSongTests
    {
        BusinessSongs songsBusiness;

        [TestInitialize]
        public void SetData()
        {
            songsBusiness = new BusinessSongs();

        }
        [TestMethod]
        public void CanSongBeInserted()
        {
            // Arrange
            Performer performer = new Performer()
            {
                Performer_Id = 124,
                Name = "Saban",
                Surname = "Saulic"
            };
            Admin admin = new Admin()
            {
                Admin_Id = 122,
                Name = "Ivan",
                Surname = "Krstic"
            };
            Song song = new Song()
            {
                Song_Id = 154,
                Performer = performer,
                Title = "Produzi dalje",
                Created_At = DateTime.Now,
                Picture_Url = "slika",
                Admin = admin,
                Jim_Rating = 9.41m,
                Youtube_Url = "www.youtube.com"
            };

            // Act
            var result = songsBusiness.InsertSong(performer, admin, song);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanSongBeUpdated()
        {
            // Arrange
            Song song = new Song()
            {
                Song_Id = 73,
                Genre = "Pop",
                Title = "Izvukla si ciglu",
                Picture_Url = "slika",
                Jim_Rating = 9.41m,
                Youtube_Url = "www.youtube.com"
            };

            // Act
            var result = songsBusiness.UpdateSong(song);

            // Assert
            Assert.AreEqual(1, result);
        }
        //Odkomentarisati, brise pesme pa ce testovi pasti
        /*     [TestMethod]
             public void CanSongBeDeleted()
             {
                 // Arrange
                 Song song = new Song()
                 {
                     Song_Id = 73,

                 };

                 // Act
                 var result = songsBusiness.DeleteSong(song);

                 // Assert
                 Assert.AreEqual(1, result);
             }*/
        [TestMethod]
        public void CandSongBeFoundByName()
        {
            // Arrange
            string name = "Izvukla si ciglu";

            // Act
            var result = songsBusiness.SearchSongByName(name);
            var count = result.Count;

            // Assert
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void CanSortReturnSongByGenre()
        {
            // Arrange
            string name = "Pop";

            // Act
            var result = songsBusiness.GetSongsByGenre(name);
            var count = result.Count;

            // Assert
            Assert.AreEqual(1, count);
        }
    }
}
