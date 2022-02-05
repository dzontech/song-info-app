using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class SongCard : UserControl
    {
        public SongCard()
        {
            InitializeComponent();
        }

        private Image _icon;
        private Image _iconRating;
        private Image _iconYoutube;
        private string _title;
        private string _genre;
        private string _performer;
        private decimal _rating;
        // Colors
        private Color _iconBackground;

        #region Properties
        [Category("Custom props")]
        public string Youtube_hyperlink { get; set; }
        [Category("Custom props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; lblIcon.Image = value; }
        }
        [Category("Custom props")]
        public Image IconRating
        {
            get { return _iconRating; }
            set { _iconRating = value; lblIconRating.Image = value; }
        }
        [Category("Custom props")]
        public Image IconYoutube
        {
            get { return _iconYoutube; }
            set { _iconYoutube = value; lblIconYoutube.Image = value; }
        }

        [Category("Custom props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        [Category("Custom props")]
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; lblGenre.Text = value; }
        }

        [Category("Custom props")]
        public string Performer
        {
            get { return _performer; }
            set { _performer = value; lblPerformer.Text = value; }
        }

        [Category("Custom props")]
        public decimal Rating
        {
            get { return _rating; }
            set { _rating = value; lblRating.Text = value.ToString(); }
        }

        [Category("Custom props")]
        public Color IconBackground
        {
            get { return _iconBackground; }
            set { _iconBackground = value; IconBackColor.BackColor = value; }
        }

        #endregion

        private void SongCard_MouseEnter_1(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(104, 66, 81);
            this.ForeColor = Color.White;
        }

        private void SongCard_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(44, 62, 80);
            this.ForeColor = Color.White;
        }

        private void LblYoutubeClick_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Youtube_hyperlink);
        }
    }
}
