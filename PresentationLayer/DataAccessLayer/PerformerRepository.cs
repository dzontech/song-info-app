using DataAccessLayer.Models;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class PerformerRepository
    {
        private static PerformerRepository _instance = null;

        private PerformerRepository() { }

        public static PerformerRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PerformerRepository();
                }
                return _instance;
            }
        }


        public int InsertPerfomer(string name, string surname)
        {
            int result = DBConnection.EditData(string.Format(
                "INSERT INTO performers (name,surname) VALUES ('{0}', '{1}');", name, surname));

            DBConnection.CloseConnection();
                return result;
        }

        public int UpdatePerformer(Performer performer)
        {
            int result = DBConnection.EditData(string.Format(
                "UPDATE performers SET name = '{0}', surname = '{1}' WHERE id = {2};", 
                performer.Name, performer.Surname, performer.Performer_Id));

            DBConnection.CloseConnection();
            return result;
        }
      
        public Performer GetPerformer(string name, string surname)
        {
            MySqlDataReader reader = DBConnection.GetData(string.Format(
                "SELECT * FROM performers WHERE name = '{0}' AND surname = '{1}';", name, surname));

                Performer performer = new Performer();
                while (reader.Read())
                {
                    performer.Performer_Id = reader.GetInt32(0);
                    performer.Name = reader.GetString(1);
                    performer.Surname = reader.GetString(2);
                }
            DBConnection.CloseConnection();
            return performer;
        }
    }
}
