using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace KlinikBerseri
{
    class ActionDAO
    {

        private MySqlCommand command = null;
        string config = "Server=localhost;Port=3306;UID=root;PWD=;Database=dbklinikberseri";
        MySqlConnection connection = new MySqlConnection();

        public ActionDAO()
        {
            connection.ConnectionString = config;
        }

        public DataSet getData()
        {
            DataSet dataSet = new DataSet();
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM actions";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataSet, "doctors");
                connection.Close();
            }
            catch (MySqlException)
            {

            }
            return dataSet;
        }

        public bool insertData(ActionModel action)
        {
            Boolean stat = false;
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO actions VALUES ('','" + action.Name + "','" + action.Price + "')";
                command.ExecuteNonQuery();
                stat = true;
                connection.Close();
            }
            catch (MySqlException)
            {

            }
            return stat;
        }

        public bool deleteData(string id)
        {
            Boolean stat = false;
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM actions WHERE id='" + id + "'";
                command.ExecuteNonQuery();
                stat = true;
                connection.Close();
            }
            catch (MySqlException)
            {

            }
            return stat;
        }

        public bool updateData(ActionModel action, int id)
        {
            Boolean stat = false;
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE actions SET name='" + action.Name + "', price='" + action.Price + "' WHERE id='" + id + "'";
                command.ExecuteNonQuery();
                stat = true;
                connection.Close();
            }
            catch (MySqlException)
            {

            }
            return stat;
        }
    }
}
