using DataAccessLayer;
using DataAccessLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class BusinessSongs
    {
        private readonly SongRepository songRepository;

        public BusinessSongs()
        {
            songRepository = SongRepository.Instance;
        }

        //************************************ Methods for CRUD songs **************************************

        // Method for insert song
        public bool InsertSong(Performer performer,Admin admin, Song song)
        {
            if (this.songRepository.InsertSong(performer, admin, song) > 0)
                return true;
            return false;
        }
        // Method for update song info
        public int UpdateSong(Song song)
        {
            return this.songRepository.UpdateSong(song);
        }
        // Method for delete song
        public int DeleteSong(Song song)
        {
            return this.songRepository.DeleteSong(song);
        }
        // Method for get all songs
        public List<Song> GetAllSongs()
        {
            return this.songRepository.GetAllSongs();
        }
        //************************************ Methods for user criteria **************************************
       // Method for search by name
       public List<Song> SearchSongByName(string name)
        {
            return this.songRepository.GetAllSongs().Where(song => song.Title.ToLower().Equals(name.ToLower())).ToList();
        }
        // Method for sort by name
        public List<Song> GetSongByName()
        {
            return this.songRepository.GetAllSongs().OrderBy(song => song.Title).ToList();
        }

        // Method for sort by rating
        public List<Song> GetSongByRating()
        {
            return this.songRepository.GetAllSongs().OrderByDescending(song => song.Jim_Rating).ToList();
        }

        // Method for sort by date
        public List<Song> GetSongByDate()
        {
            return this.songRepository.GetAllSongs().OrderByDescending(song => song.Created_At).ToList();
        }

        //************************************ Methods for genres *********************************************

        // Method for Motivation songs
        public List<Song> GetSongsMotivation()
        {
            return this.songRepository.GetAllSongs().Where(song => song.Genre.Equals("Motivation")).ToList();
        }

        // Method for Chill songs
        public List<Song> GetSongsChill()
        {
            return this.songRepository.GetAllSongs().Where(song => song.Genre.Equals("Chill")).ToList();
        }

        // Method for Jazz songs
        public List<Song> GetSongsJazz()
        {
            return this.songRepository.GetAllSongs().Where(song => song.Genre.Equals("Jazz")).ToList();
        }

        // Method for Folk songs
        public List<Song> GetSongsFolk()
        {
            return this.songRepository.GetAllSongs().Where(song => song.Genre.Equals("Folk")).ToList();
        }

        // Method for Rock songs
        public List<Song> GetSongsRock()
        {
            return this.songRepository.GetAllSongs().Where(song => song.Genre == "Rock").ToList();
        }

        // Method for Folk songs
        public List<Song> GetSongsPop()
        {
            return this.songRepository.GetAllSongs().Where(song => song.Genre.Equals("Pop")).ToList();
        }

        public List<Song> GetSongsByGenre(string genre)
        {
            return this.songRepository.GetAllSongs().Where(song => song.Genre.Equals(genre.ToLower())).ToList();
        }

        public bool CheckIfSongExists(string title, string name, string surname)
        {
            if (songRepository.GetSongByTitleAndPerformer(title, name, surname).Song_Id > 0)
                return true;
            return false;
        }
    }
}
