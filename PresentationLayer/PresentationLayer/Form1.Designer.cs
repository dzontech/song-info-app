namespace PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnEditSongs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHelp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnContact = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGenres = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNewSongs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.contact1 = new PresentationLayer.contact();
            this.genres1 = new PresentationLayer.Genres();
            this.adminlogin1 = new PresentationLayer.Adminlogin();
            this.songinfoinput1 = new PresentationLayer.Songinfoinput();
            this.newsongs1 = new PresentationLayer.Newsongs();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.btnEditSongs);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnHelp);
            this.panelMenu.Controls.Add(this.btnContact);
            this.panelMenu.Controls.Add(this.btnAdmin);
            this.panelMenu.Controls.Add(this.btnGenres);
            this.panelMenu.Controls.Add(this.btnNewSongs);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.bunifuGradientPanel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelMenu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelMenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelMenu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Quality = 10;
            this.panelMenu.Size = new System.Drawing.Size(245, 635);
            this.panelMenu.TabIndex = 0;
            // 
            // btnEditSongs
            // 
            this.btnEditSongs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnEditSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnEditSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditSongs.BorderRadius = 0;
            this.btnEditSongs.ButtonText = "Edit Songs";
            this.btnEditSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSongs.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditSongs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditSongs.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditSongs.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditSongs.Iconimage")));
            this.btnEditSongs.Iconimage_right = null;
            this.btnEditSongs.Iconimage_right_Selected = null;
            this.btnEditSongs.Iconimage_Selected = null;
            this.btnEditSongs.IconMarginLeft = 0;
            this.btnEditSongs.IconMarginRight = 0;
            this.btnEditSongs.IconRightVisible = true;
            this.btnEditSongs.IconRightZoom = 0D;
            this.btnEditSongs.IconVisible = true;
            this.btnEditSongs.IconZoom = 50D;
            this.btnEditSongs.IsTab = false;
            this.btnEditSongs.Location = new System.Drawing.Point(0, 447);
            this.btnEditSongs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditSongs.Name = "btnEditSongs";
            this.btnEditSongs.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnEditSongs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.btnEditSongs.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditSongs.selected = false;
            this.btnEditSongs.Size = new System.Drawing.Size(245, 59);
            this.btnEditSongs.TabIndex = 9;
            this.btnEditSongs.Text = "Edit Songs";
            this.btnEditSongs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditSongs.Textcolor = System.Drawing.Color.White;
            this.btnEditSongs.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSongs.Click += new System.EventHandler(this.BtnEditSongs_Click);
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "Exit";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExit.Iconimage")));
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 50D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(0, 576);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(245, 59);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.BorderRadius = 0;
            this.btnHelp.ButtonText = "Help";
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.DisabledColor = System.Drawing.Color.Gray;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHelp.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHelp.Iconimage")));
            this.btnHelp.Iconimage_right = null;
            this.btnHelp.Iconimage_right_Selected = null;
            this.btnHelp.Iconimage_Selected = null;
            this.btnHelp.IconMarginLeft = 0;
            this.btnHelp.IconMarginRight = 0;
            this.btnHelp.IconRightVisible = true;
            this.btnHelp.IconRightZoom = 0D;
            this.btnHelp.IconVisible = true;
            this.btnHelp.IconZoom = 50D;
            this.btnHelp.IsTab = false;
            this.btnHelp.Location = new System.Drawing.Point(0, 388);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnHelp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.btnHelp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHelp.selected = false;
            this.btnHelp.Size = new System.Drawing.Size(245, 59);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHelp.Textcolor = System.Drawing.Color.White;
            this.btnHelp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnContact
            // 
            this.btnContact.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContact.BorderRadius = 0;
            this.btnContact.ButtonText = "Contact";
            this.btnContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContact.DisabledColor = System.Drawing.Color.Gray;
            this.btnContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContact.Iconcolor = System.Drawing.Color.Transparent;
            this.btnContact.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnContact.Iconimage")));
            this.btnContact.Iconimage_right = null;
            this.btnContact.Iconimage_right_Selected = null;
            this.btnContact.Iconimage_Selected = null;
            this.btnContact.IconMarginLeft = 0;
            this.btnContact.IconMarginRight = 0;
            this.btnContact.IconRightVisible = true;
            this.btnContact.IconRightZoom = 0D;
            this.btnContact.IconVisible = true;
            this.btnContact.IconZoom = 50D;
            this.btnContact.IsTab = false;
            this.btnContact.Location = new System.Drawing.Point(0, 329);
            this.btnContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContact.Name = "btnContact";
            this.btnContact.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnContact.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.btnContact.OnHoverTextColor = System.Drawing.Color.White;
            this.btnContact.selected = false;
            this.btnContact.Size = new System.Drawing.Size(245, 59);
            this.btnContact.TabIndex = 6;
            this.btnContact.Text = "Contact";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnContact.Textcolor = System.Drawing.Color.White;
            this.btnContact.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.Click += new System.EventHandler(this.BtnContact_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.BorderRadius = 0;
            this.btnAdmin.ButtonText = "Admin";
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Iconimage")));
            this.btnAdmin.Iconimage_right = null;
            this.btnAdmin.Iconimage_right_Selected = null;
            this.btnAdmin.Iconimage_Selected = null;
            this.btnAdmin.IconMarginLeft = 0;
            this.btnAdmin.IconMarginRight = 0;
            this.btnAdmin.IconRightVisible = true;
            this.btnAdmin.IconRightZoom = 0D;
            this.btnAdmin.IconVisible = true;
            this.btnAdmin.IconZoom = 50D;
            this.btnAdmin.IsTab = false;
            this.btnAdmin.Location = new System.Drawing.Point(0, 270);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.btnAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdmin.selected = false;
            this.btnAdmin.Size = new System.Drawing.Size(245, 59);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdmin.Textcolor = System.Drawing.Color.White;
            this.btnAdmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // btnGenres
            // 
            this.btnGenres.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnGenres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenres.BorderRadius = 0;
            this.btnGenres.ButtonText = "Genres";
            this.btnGenres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenres.DisabledColor = System.Drawing.Color.Gray;
            this.btnGenres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenres.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenres.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGenres.Iconimage")));
            this.btnGenres.Iconimage_right = null;
            this.btnGenres.Iconimage_right_Selected = null;
            this.btnGenres.Iconimage_Selected = null;
            this.btnGenres.IconMarginLeft = 0;
            this.btnGenres.IconMarginRight = 0;
            this.btnGenres.IconRightVisible = true;
            this.btnGenres.IconRightZoom = 0D;
            this.btnGenres.IconVisible = true;
            this.btnGenres.IconZoom = 50D;
            this.btnGenres.IsTab = false;
            this.btnGenres.Location = new System.Drawing.Point(0, 211);
            this.btnGenres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenres.Name = "btnGenres";
            this.btnGenres.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnGenres.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.btnGenres.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGenres.selected = false;
            this.btnGenres.Size = new System.Drawing.Size(245, 59);
            this.btnGenres.TabIndex = 4;
            this.btnGenres.Text = "Genres";
            this.btnGenres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenres.Textcolor = System.Drawing.Color.White;
            this.btnGenres.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenres.Click += new System.EventHandler(this.BtnGenres_Click);
            // 
            // btnNewSongs
            // 
            this.btnNewSongs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNewSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNewSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewSongs.BorderRadius = 0;
            this.btnNewSongs.ButtonText = "New Songs";
            this.btnNewSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSongs.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewSongs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewSongs.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewSongs.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNewSongs.Iconimage")));
            this.btnNewSongs.Iconimage_right = null;
            this.btnNewSongs.Iconimage_right_Selected = null;
            this.btnNewSongs.Iconimage_Selected = null;
            this.btnNewSongs.IconMarginLeft = 0;
            this.btnNewSongs.IconMarginRight = 0;
            this.btnNewSongs.IconRightVisible = true;
            this.btnNewSongs.IconRightZoom = 0D;
            this.btnNewSongs.IconVisible = true;
            this.btnNewSongs.IconZoom = 50D;
            this.btnNewSongs.IsTab = false;
            this.btnNewSongs.Location = new System.Drawing.Point(0, 152);
            this.btnNewSongs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewSongs.Name = "btnNewSongs";
            this.btnNewSongs.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNewSongs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.btnNewSongs.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewSongs.selected = false;
            this.btnNewSongs.Size = new System.Drawing.Size(245, 59);
            this.btnNewSongs.TabIndex = 3;
            this.btnNewSongs.Text = "New Songs";
            this.btnNewSongs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewSongs.Textcolor = System.Drawing.Color.White;
            this.btnNewSongs.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSongs.Click += new System.EventHandler(this.BtnNewSongs_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 152);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(25, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(185, 117);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logo_MouseDown);
            this.logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logo_MouseMove);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(258, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(948, 633);
            this.bunifuGradientPanel2.TabIndex = 1;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.contact1);
            this.bunifuGradientPanel3.Controls.Add(this.genres1);
            this.bunifuGradientPanel3.Controls.Add(this.adminlogin1);
            this.bunifuGradientPanel3.Controls.Add(this.songinfoinput1);
            this.bunifuGradientPanel3.Controls.Add(this.newsongs1);
            this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(245, 0);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(923, 635);
            this.bunifuGradientPanel3.TabIndex = 1;
            // 
            // contact1
            // 
            this.contact1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contact1.Location = new System.Drawing.Point(0, 0);
            this.contact1.Name = "contact1";
            this.contact1.Size = new System.Drawing.Size(923, 635);
            this.contact1.TabIndex = 4;
            // 
            // genres1
            // 
            this.genres1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genres1.Location = new System.Drawing.Point(0, 0);
            this.genres1.Name = "genres1";
            this.genres1.Size = new System.Drawing.Size(923, 635);
            this.genres1.TabIndex = 3;
            // 
            // adminlogin1
            // 
            this.adminlogin1.BackColor = System.Drawing.Color.Transparent;
            this.adminlogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminlogin1.Location = new System.Drawing.Point(0, 0);
            this.adminlogin1.Name = "adminlogin1";
            this.adminlogin1.Size = new System.Drawing.Size(923, 635);
            this.adminlogin1.TabIndex = 2;
            // 
            // songinfoinput1
            // 
            this.songinfoinput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songinfoinput1.Location = new System.Drawing.Point(0, 0);
            this.songinfoinput1.Name = "songinfoinput1";
            this.songinfoinput1.Size = new System.Drawing.Size(923, 635);
            this.songinfoinput1.TabIndex = 1;
            // 
            // newsongs1
            // 
            this.newsongs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.newsongs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsongs1.Location = new System.Drawing.Point(0, 0);
            this.newsongs1.Name = "newsongs1";
            this.newsongs1.Size = new System.Drawing.Size(923, 635);
            this.newsongs1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1168, 635);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Song Info App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panelMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnHelp;
        private Bunifu.Framework.UI.BunifuFlatButton btnContact;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdmin;
        private Bunifu.Framework.UI.BunifuFlatButton btnGenres;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewSongs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Newsongs newsongs1;
        private Songinfoinput songinfoinput1;
        private Adminlogin adminlogin1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditSongs;
        private Genres genres1;
        private contact contact1;
    }
}