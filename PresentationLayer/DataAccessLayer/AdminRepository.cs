using DataAccessLayer.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class AdminRepository
    {

        private static AdminRepository _instance = null;

        private AdminRepository() { }

        public static AdminRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AdminRepository();
                }
                return _instance;
            }
        }



        private readonly List<Admin> list = new List<Admin>();

        public int RegisterAdmin(Admin admin)
        {
            int result = 0;
            if (!GetAdmin().Contains(admin))
            {
                result = DBConnection.EditData(string.Format(
                "INSERT INTO admins(name, surname, username, password) " +
                "VALUES ('{0}','{1}','{2}',md5('{3}'));", admin.Name,
                admin.Surname, admin.Username, admin.Password));

                DBConnection.CloseConnection();
            }
                return result;
        }

        // Checking if Admin Username already exists in database
        public List<Admin> GetAdmin()
        {
                List<Admin> list2 = new List<Admin>();
                Admin temp = new Admin();
                MySqlDataReader reader = DBConnection.GetData("SELECT * FROM admins;");

                while (reader.Read())
                {
                    temp.Admin_Id = Convert.ToInt32(reader.GetString(0));
                    temp.Name = reader.GetString(1);
                    temp.Surname = reader.GetString(2);
                    temp.Username = reader.GetString(3);
                    temp.Password = reader.GetString(4);
                    list2.Add(temp);
                }
            DBConnection.CloseConnection();
                return list2;
        }

        public Admin AuthenticateAdmin(Admin admin)
        {
                Admin temp = new Admin();

         MySqlDataReader reader = DBConnection.GetData(string.Format(
             "SELECT * FROM admins WHERE username = '{0}' AND password = md5('{1}');", 
             admin.Username, admin.Password));

                while (reader.Read())
                {
                    temp.Admin_Id = reader.GetInt32(0);
                    temp.Name = reader.GetString(1);
                    temp.Surname = reader.GetString(2);
                    temp.Username = reader.GetString(3);
                    temp.Password = reader.GetString(4);
                }
        DBConnection.CloseConnection();
                return temp;
        }

        public int UpdateAdmin(Admin admin)
        {
            int result = DBConnection.EditData(string.Format(
                "UPDATE admins SET name = '{0}', surname='{1}', username='{2}', " +
                "password=md5('{3}') WHERE id = {4};",admin.Name, admin.Surname, 
                admin.Username, admin.Password, admin.Admin_Id));
            DBConnection.CloseConnection();
                return result;
        }
        // For Integration testing
        public int DeleteAdmin(Admin admin)
        {
            int result = DBConnection.EditData(string.Format(
                "DELETE FROM admins WHERE username='{0}'", admin.Username
                ));
            DBConnection.CloseConnection();
            return result;
        }
    }
}
