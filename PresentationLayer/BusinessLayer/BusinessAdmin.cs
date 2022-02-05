using DataAccessLayer;
using DataAccessLayer.Models;
using System.Text.RegularExpressions;

namespace BusinessLayer
{
    public class BusinessAdmin
    {
        private readonly AdminRepository adminRepository;

        public BusinessAdmin()
        {
            adminRepository = AdminRepository.Instance;
        }

        //************************************ Methods for CRUD admin **************************************

        // Method for admin registration/add admin
        public int RegisterAdmin(Admin admin)
        {
            return this.adminRepository.RegisterAdmin(admin);
        }

        // Method for Admin Login
        public bool GetAdmin()
        {
            if (this.adminRepository.GetAdmin().Count > 0)
                return true;
            return false;
        }

        // Method for Authenticate
        public Admin AuthenticateAdmin(Admin admin)
        {
            return this.adminRepository.AuthenticateAdmin(admin);
        }

        // Method for update admin info
        public int UpdateAdmin(Admin admin)
        {
            return this.adminRepository.UpdateAdmin(admin);
        }

        // Method for delete admin info
        public int DeleteAdmin(Admin admin)
        {
            return this.adminRepository.DeleteAdmin(admin);
        }

        //************************************ Methods for Check validation **************************************

        // Method for check password validation
        public bool IsValidPassword(string passw)
        { 
            // example of password:  Adminpp1, one upperCase, one Number, minimum 8 characters
            var hasNumber = new Regex(@"[0-9]$");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var isValidated = hasNumber.IsMatch(passw) && hasUpperChar.IsMatch(passw) && hasMinimum8Chars.IsMatch(passw);
            if (isValidated)
                return true;
            return false;
        }

        // Method for check username validation
        public bool IsValidUsername(string username)
        {
            //example of username: adminadmin or Adminadmin , just characters and min 8 characters
            var hasUpperChar = new Regex(@"^[a-zA-Z]+$");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var isValidated =  hasUpperChar.IsMatch(username) && hasMinimum8Chars.IsMatch(username);
            if (isValidated)
                return true;
            return false;
        }
    }
}
