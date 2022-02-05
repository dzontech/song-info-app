using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public sealed class DBConnection
    {
        private static MySqlConnection _mySqlConnection = null;
        private static MySqlCommand _mySqlCommand = null;

        private DBConnection() { }

        // Created once instance of MySqlConnection
        private static MySqlConnection MyConnection
        {
            get
            {
                if (_mySqlConnection == null)
                {
                    _mySqlConnection = new MySqlConnection(Constants.connectionString);
                }
                return _mySqlConnection;
            }
        }

        // Created once instance of MySqlCommand
        private static MySqlCommand MyCommand
        {
            get
            {
                if (_mySqlCommand == null)
                {
                    _mySqlCommand = new MySqlCommand
                    {
                        Connection = MyConnection
                    };
                }
                return _mySqlCommand;
            }
        }

        // Method for Open Connection
        private static void OpenConnection()
        {
            CloseConnection();
            if (_mySqlConnection != null)
            {
                _mySqlConnection.Open();
            }
        }

        // Method for Close Connection
        public static void CloseConnection()
        {
            if(_mySqlConnection != null)
            {
                _mySqlConnection.Close();
            }
        }

        // Handler for DataReader
        public static MySqlDataReader GetData(string commandText)
        {
            if(MyConnection != null && MyCommand != null)
            {
                OpenConnection();
                _mySqlCommand.CommandText = commandText;
                var result = _mySqlCommand.ExecuteReader();

                return result;
            }
            return null;
        }

        // Method for edit data in insert, update, delete state
        public static int EditData(string commandText)
        {
            if(MyConnection != null && MyCommand != null)
            {
                OpenConnection();
                _mySqlCommand.CommandText = commandText;
                var result = _mySqlCommand.ExecuteNonQuery();
                
                return result;
            }
            return 0;
        }
    }
}
