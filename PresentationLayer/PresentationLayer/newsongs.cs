using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;
using PresentationLayer.Properties;
using DataAccessLayer.Models;

namespace PresentationLayer
{
    public partial class Newsongs : UserControl
    {
        private readonly BusinessSongs blSong;
        public string SelectedGenre;

        public Newsongs()
        {
            InitializeComponent();
            blSong = new BusinessSongs();
            SongsItems(this.blSong.GetAllSongs());
        }
        private void SongsItems(List<Song> listSong)
        {
            ClearList();
            var Songs = listSong;
            var listLength = listSong.Count;

            SongCard[] listSongs = new SongCard[listLength];
           
            for (int i = 0; i < listLength; i++)
            {
               // Song info
                listSongs[i] = new SongCard();
                listSongs[i].Icon = Resources.music;
                listSongs[i].IconRating = Resources.star;
                listSongs[i].IconYoutube = Resources.youtube;
                listSongs[i].IconBackground = Color.FromArgb(44, 62, 80);
                listSongs[i].Youtube_hyperlink = Songs[i].Youtube_Url;
                listSongs[i].Title = Songs[i].Title;
                listSongs[i].Genre = Songs[i].Genre;
                listSongs[i].Performer = Songs[i].Performer.Name + " " + Songs[i].Performer.Surname;
                listSongs[i].Rating = Songs[i].Jim_Rating;
                
                // Add to flow panel
                flowListSongs.Controls.Add(listSongs[i]);
            }
        }
        private void ClearList()
        {
            flowListSongs.Controls.Clear();
        }

        // Get All Songs
        private void GetAllSongs_Click(object sender, EventArgs e)
        {
            var Songs = this.blSong.GetAllSongs();
            var listLength = this.blSong.GetAllSongs().Count;

            if (listLength != 0)
            {
                SongsItems(Songs);
            }
            else
            {
                MessageBox.Show("There are no songs!");
            }
        }
        // Sort method for songs by name
        private void BtnAZSort_Click(object sender, EventArgs e)
        {
            var Songs = this.blSong.GetSongByName();
            var listLength = this.blSong.GetSongByName().Count;

            if (listLength != 0)
            {
                SongsItems(Songs);
            }
            else
            {
                MessageBox.Show("There are no songs!");
            }
        }

        // Sort method for songs by rating
        private void BtnRatingSort_Click(object sender, EventArgs e)
        {
            var Songs = this.blSong.GetSongByRating();
            var listLength = this.blSong.GetSongByRating().Count;

            if (listLength != 0)
            {
                SongsItems(Songs);
            }
            else
            {
                MessageBox.Show("There are no songs!");
            }
        }

        // Sort method for songs by date
        private void BtnDateSort_Click(object sender, EventArgs e)
        {
            var Songs = this.blSong.GetSongByDate();
            var listLength = this.blSong.GetSongByDate().Count;

            if (listLength != 0)
            {
                SongsItems(Songs);
            }
            else
            {
                MessageBox.Show("There are no songs!");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text;

            var Songs = this.blSong.SearchSongByName(searchValue);
            
            SongsItems(Songs);
        }
    }
}
