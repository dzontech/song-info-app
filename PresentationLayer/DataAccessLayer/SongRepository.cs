using DataAccessLayer.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class SongRepository
    {
        private static SongRepository _instance = null;
        private SongRepository() { }


        public static SongRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SongRepository();
                }
                return _instance;
            }
        }

        public int InsertSong(Performer performer, Admin admin, Song song)
        {
                int result = DBConnection.EditData(string.Format(
                    "INSERT INTO songs (performer_id, title, picture_url, genre, " +
                    "admin_id, jim_rating, youtube_url) VALUES ({0}, '{1}','{2}', " +
                    "'{3}', {4}, {5}, '{6}');", performer.Performer_Id, song.Title, 
                    song.Picture_Url, song.Genre, admin.Admin_Id, song.Jim_Rating, 
                    song.Youtube_Url));
            DBConnection.CloseConnection();
            return result;
        }

        public int UpdateSong(Song song)
        {
            int result = DBConnection.EditData(string.Format(
                "UPDATE songs SET title = '{0}', genre = '{1}', jim_rating = {2}, " +
                "youtube_url = '{3}' WHERE songs.id = {4};", 
                song.Title, song.Genre, song.Jim_Rating, song.Youtube_Url, song.Song_Id));
            DBConnection.CloseConnection();
            return result;
        }

        public int DeleteSong(Song song)
        {
            int result = DBConnection.EditData(string.Format(
                "DELETE FROM songs WHERE id = '{0}'", song.Song_Id));
            DBConnection.CloseConnection();
            return result;
        }

        public List<Song> GetAllSongs()
        {
            List<Song> songs = new List<Song>();

            MySqlDataReader reader = DBConnection.GetData
                (@"SELECT songs.id,performers.id, performers.name, performers.surname, 
                    songs.title,created_at, songs.picture_url, genre,admins.id, admins.name, 
                    admins.surname, jim_rating, youtube_url
                                        FROM songs
                                        JOIN admins
                                            ON songs.admin_id = admins.id
                                        JOIN performers
                                            ON performers.id = songs.performer_id;");
            while (reader.Read())
            {
                Song song = new Song();
                song.Performer = new Performer();
                song.Admin = new Admin();

                song.Song_Id = reader.GetInt32(0);
                song.Performer.Performer_Id = reader.GetInt32(1);
                song.Performer.Name = reader.GetString(2);
                song.Performer.Surname = reader.GetString(3);
                song.Title = reader.GetString(4);
                song.Created_At = reader.GetDateTime(5);
                song.Picture_Url = reader.GetString(6);
                song.Genre = reader.GetString(7);
                song.Admin.Admin_Id = reader.GetInt32(8);
                song.Admin.Name = reader.GetString(9);
                song.Admin.Surname = reader.GetString(10);
                song.Jim_Rating = reader.GetDecimal(11);
                song.Youtube_Url = reader.GetString(12);

                songs.Add(song);
            }

            DBConnection.CloseConnection();
            return songs;
        }
        public Song GetSongByTitleAndPerformer(string title, string name, string surname)
        {
            Song song = new Song();

            MySqlDataReader reader = DBConnection.GetData(string.Format(@"SELECT
	                                         songs.id AS 'song id',
                                             songs.title AS 'Naziv pesme'
                                        FROM songs
                                        JOIN performers
	                                         ON performers.id = songs.performer_id
                                        WHERE songs.title = '{0}' AND performers.name = '{1}'
                                            AND  performers.surname = '{2}';", title, name, surname));
                while (reader.Read())
                {
                    song.Song_Id = reader.GetInt32(0);
                    song.Title = reader.GetString(1);
                }
          
            return song;
        }
    }
}
