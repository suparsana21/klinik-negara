using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace KlinikBerseri
{
    class PatientDAO
    {
        private MySqlCommand command = null;
        string config = "Server=localhost;Port=3306;UID=root;PWD=;Database=dbklinikberseri";
        MySqlConnection connection = new MySqlConnection();

        public PatientDAO()
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
                command.CommandText = "SELECT * FROM patients";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataSet, "patients");
                connection.Close();
            }
            catch (MySqlException)
            {

            }
            return dataSet;
        }

        public bool insertData(PatientModel patient)
        {
            Boolean stat = false;
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO patients VALUES ('','" + patient.Name + "','"+ patient.Gendre +"','" + patient.Address + "','" + patient.Phone + "')";
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
                command.CommandText = "DELETE FROM patients WHERE id='" + id + "'";
                command.ExecuteNonQuery();
                stat = true;
                connection.Close();
            }
            catch (MySqlException)
            {

            }
            return stat;
        }

        public bool editData(string id)
        {
            Boolean stat = false;
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FORM patients WHERE id='" + id + "'";
                command.ExecuteNonQuery();
                stat = true;
                connection.Close();
            }
            catch (MySqlException)
            {

            }
            return stat;
        }

        public bool updateData(PatientModel patient, int id)
        {
            Boolean stat = false;
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE patients SET name='" + patient.Name + "', gendre='" + patient.Gendre + "', address='" + patient.Address + "', phone='" + patient.Phone + "' WHERE id='" + id + "'";
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
