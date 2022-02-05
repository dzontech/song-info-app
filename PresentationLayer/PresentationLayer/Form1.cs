using BusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly BusinessAdmin businessAdmin;
        
        public Form1()
        {
            InitializeComponent();
            businessAdmin = new BusinessAdmin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newsongs1.Show();
            adminlogin1.Hide();
            songinfoinput1.Hide();

            btnEditSongs.Hide();
            genres1.Hide();
            contact1.Hide();
        }
        
        private void BtnNewSongs_Click(object sender, EventArgs e)
        {
            newsongs1.Show();
            adminlogin1.Hide();
            songinfoinput1.Hide();
            genres1.Hide();
            contact1.Hide();
        }
        private void BtnGenres_Click(object sender, EventArgs e)
        {
            newsongs1.Hide();
            newsongs1.SendToBack();
            adminlogin1.Hide();
            songinfoinput1.Hide();
            genres1.Show();

            genres1.flowLayoutPanel1.Hide();
            contact1.Hide();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Adminlogin al = new Adminlogin();
            newsongs1.Hide();
            adminlogin1.Show();
            songinfoinput1.Hide();
            genres1.Hide();
            contact1.Hide();
        }

        private void BtnContact_Click(object sender, EventArgs e)
        {
            newsongs1.Hide();
            newsongs1.SendToBack();
            adminlogin1.Hide();
            songinfoinput1.Hide();
            genres1.Show();

            genres1.flowLayoutPanel1.Hide();
            contact1.Show();
        }

        private void BtnEditSongs_Click(object sender, EventArgs e)
        {
            newsongs1.Hide();
            adminlogin1.Hide();
            songinfoinput1.Show();
            btnEditSongs.Show();
            genres1.Hide();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(2);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=HHdB_rLsMY8&feature=youtu.be");
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void logo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void logo_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
