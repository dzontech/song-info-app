using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;
using DataAccessLayer.Models;

namespace PresentationLayer
{
    public partial class Adminlogin : UserControl
    {
        public BusinessAdmin business;
        public static Admin adminData;

        public Adminlogin()
        {
            business = new BusinessAdmin();

            InitializeComponent();
            star1.Hide();
            star2.Hide();
            panelRegistration.Hide();
        }

        private void Adminlogin_Load(object sender, EventArgs e)
        {
            songinfoinput1.Hide();
            panelUpdateAdmin.Hide();
            Admin a = new Admin();
            // Color right Sign In
            btnSignInHaveAccount.ActiveFillColor = Color.FromArgb(44, 62, 80);
            btnSignInHaveAccount.ActiveForecolor = Color.Transparent;
            btnSignInHaveAccount.ActiveLineColor = Color.FromArgb(44, 62, 80);
            btnSignInHaveAccount.BackColor = Color.Transparent;
            btnSignInHaveAccount.IdleForecolor = Color.Transparent;
            // Color left Sign In
            btnSignInNoFunction.ActiveFillColor = Color.FromArgb(44, 62, 80);
            btnSignInNoFunction.ActiveForecolor = Color.Transparent;
            btnSignInNoFunction.ActiveLineColor = Color.FromArgb(44, 62, 80);
            btnSignInNoFunction.BackColor = Color.Transparent;
            btnSignInNoFunction.IdleForecolor = Color.Transparent;
            // Color register now
            btnRegisterNowCreate.ActiveFillColor = Color.FromArgb(44, 62, 80);
            btnRegisterNowCreate.ActiveForecolor = Color.Transparent;
            btnRegisterNowCreate.ActiveLineColor = Color.FromArgb(44, 62, 80);
            btnRegisterNowCreate.BackColor = Color.Transparent;
            btnRegisterNowCreate.IdleForecolor = Color.Transparent;
            // Color register now
            btnRegisterNow.ActiveFillColor = Color.FromArgb(44, 62, 80);
            btnRegisterNow.ActiveForecolor = Color.Transparent;
            btnRegisterNow.ActiveLineColor = Color.FromArgb(44, 62, 80);
            btnRegisterNow.BackColor = Color.Transparent;
            btnRegisterNow.IdleForecolor = Color.Transparent;
            // Color update now
            btnUpdateAdminInfo.ActiveFillColor = Color.FromArgb(44, 62, 80);
            btnUpdateAdminInfo.ActiveForecolor = Color.Transparent;
            btnUpdateAdminInfo.ActiveLineColor = Color.FromArgb(44, 62, 80);
            btnUpdateAdminInfo.BackColor = Color.Transparent;
            btnUpdateAdminInfo.IdleForecolor = Color.Transparent;
            // Color show panel
            btnUpdateAdminShowPanel.ActiveFillColor = Color.FromArgb(44, 62, 80);
            btnUpdateAdminShowPanel.ActiveForecolor = Color.Transparent;
            btnUpdateAdminShowPanel.ActiveLineColor = Color.FromArgb(44, 62, 80);
            btnUpdateAdminShowPanel.BackColor = Color.Transparent;
            btnUpdateAdminShowPanel.IdleForecolor = Color.Transparent;
            
            if (this.business.GetAdmin())
            {
                labelRegistration.Hide();
                btnRegisterNow.Hide();
            }
        }

        /*Sprecavanje unosa praznih polja*/
        private void BtnSignInHaveAccount_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();

            if (textBoxPasswordHaveAccount.Text.Length == 0
                || textBoxUserNameHaveAccount.Text.Length == 0
                || this.business.IsValidPassword(textBoxPasswordHaveAccount.Text) != true
                || this.business.IsValidUsername(textBoxUserNameHaveAccount.Text) != true)
            {
                star1.Show();
                star2.Show();
                MessageBox.Show("Enter correct data!");
            }
            else
            {
                a.Username = textBoxUserNameHaveAccount.Text;
                a.Password = textBoxPasswordHaveAccount.Text;
               
                if (this.business.AuthenticateAdmin(a).Admin_Id != 0)
                {
                    MessageBox.Show("Successfull login!");
                    songinfoinput1.Show();
                    panelRegistration.Hide();
                    // Data stored for songinput
                    adminData = new Admin();
                    adminData.Username = a.Username;
                    adminData.Password = a.Password;
                }
                else
                {
                    MessageBox.Show("Unsuccessful login!");
                }
            }
        }
        
        /*Prikaz panela za registraciju*/
        private void BtnRegisterNow_Click(object sender, EventArgs e)
        {
            panelRegistration.Show();
            star9.Hide();
            star10.Hide();
            star11.Hide();
            star12.Hide();
        }

        /*Ponovnim klikom na Sign In se vracamo nazad na logovanje*/
        private void BtnSignInNoFunction_Click(object sender, EventArgs e)
        {
            panelRegistration.Hide();
            panelUpdateAdmin.Hide();
            songinfoinput1.Hide();
        }

        /*Sprecavanje unosa praznih polja*/
        private void BtnRegisterNowCreate_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();

            if ( textBoxName.Text.Length == 0
                || textBoxSurname.Text.Length == 0
                || textBoxUsername.Text.Length == 0
                || textBoxPassword.Text.Length == 0
                || this.business.IsValidPassword(textBoxPassword.Text) != true
                || this.business.IsValidUsername(textBoxUsername.Text) != true )
            {
                star9.Show();
                star10.Show();
                star11.Show();
                star12.Show();

                MessageBox.Show("Enter correct data!(Username: characters only, min 8 char;Password: one Uppercase, one Number, min 8 char)");
            }
            else
            {
                a.Name = textBoxName.Text;
                a.Surname = textBoxSurname.Text;
                a.Username = textBoxUsername.Text;
                a.Password = textBoxPassword.Text;

                adminData = new Admin();
                adminData.Username = a.Username;
                adminData.Password = a.Password;

                if (this.business.RegisterAdmin(a) != 0)
                {
                    MessageBox.Show("Successfull registration!");
                    songinfoinput1.Show();
                }
                else
                {
                    MessageBox.Show("Unsuccessfull registration!");
                }
            }
        }

        private void BtnUpdateAdminShowPanel_Click(object sender, EventArgs e)
        {
            star9.Hide();
            star10.Hide();
            star11.Hide();
            star12.Hide();
            star15.Hide();
            star16.Hide();
            star17.Hide();
            star18.Hide();

            Admin a = new Admin();

            if (textBoxPasswordHaveAccount.Text.Length == 0
               || textBoxUserNameHaveAccount.Text.Length == 0
               || this.business.IsValidPassword(textBoxPasswordHaveAccount.Text) != true
               || this.business.IsValidUsername(textBoxUserNameHaveAccount.Text) != true)
            {

                star1.Show();
                star2.Show();
                MessageBox.Show("Enter correct data!");
            }
            else
            {
                a.Username = textBoxUserNameHaveAccount.Text;
                a.Password = textBoxPasswordHaveAccount.Text;
                // Kupim podatke
                adminData = new Admin();
                adminData.Username = a.Username;
                adminData.Password = a.Password;

                if (this.business.AuthenticateAdmin(a).Admin_Id != 0)
                {

                    MessageBox.Show("You are registered admin!");

                    panelUpdateAdmin.Show();

                }
                else
                {
                    MessageBox.Show("Enter correct data!");
                }
            }
        }

        private void BtnUpdateAdminInfo_Click_1(object sender, EventArgs e)
        {
            Admin a = new Admin();

            a.Name = textBoxUpdateAdminName.Text;
            a.Surname = textBoxUpdateAdminSurname.Text;
            a.Username = textBoxUpdateAdminUsername.Text;
            a.Password = textBoxUpdateAdminPassword.Text;

            a.Admin_Id = this.business.AuthenticateAdmin(Adminlogin.adminData).Admin_Id;

            if (this.business.UpdateAdmin(a) > 0)
            {
                MessageBox.Show("Admin info successfully updated!");
                btnSignInNoFunction.Show();
                label4.Show();
            }
            else
            {
                MessageBox.Show("Unsuccessfull update!");
            }
        }
    }
}
