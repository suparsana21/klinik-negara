using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace KlinikBerseri
{
    class DoctorDAO
    {
        private MySqlCommand command = null;
        string config = "Server=localhost;Port=3306;UID=root;PWD=;Database=dbklinikberseri";
        MySqlConnection connection = new MySqlConnection();

        public DoctorDAO()
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
                command.CommandText = "SELECT * FROM doctors";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataSet, "doctors");
                connection.Close();
            }
            catch (MySqlException) {
                
            }
            return dataSet;
        }

        public bool insertData(DoctorModel doctor)
        {
            Boolean stat = false;
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO doctors VALUES ('','" + doctor.Name + "','" + doctor.Address + "','" + doctor.Phone + "','" + doctor.Specialist + "')";
                command.ExecuteNonQuery();
                stat = true;
                connection.Close();
            }
            catch(MySqlException) {
            
            }
            return stat;
        }

        public bool deleteData(int id)
        {
            Boolean stat = false;
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM doctors WHERE id='"+id+"'";
                command.ExecuteNonQuery();
                stat = true;
                connection.Close();
            }
            catch (MySqlException)
            {

            }
            return stat;
        }

        public bool updateData(DoctorModel doctor, int id)
        {
            Boolean stat = false;
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE doctor SET name='"+doctor.Name+"', address='"+doctor.Address+"', phone='"+doctor.Phone+"', '"+doctor.Specialist+"' WHERE id='"+id+"'";
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
