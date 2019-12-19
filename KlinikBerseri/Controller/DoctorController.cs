using KlinikBerseri.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikBerseri.Controller
{
   class DoctorController
   {
       private MySqlCommand cmd = null;
       string config = "Server=127.0.0.1;Port=3306;Uid=root;Pwd=;Database=local_klinikberseri";
       public static MySqlConnection conn = new MySqlConnection();

       public DoctorController()
       {
          
           conn.ConnectionString = config;
       }

       public DataSet getData()
       {

           DataSet ds = new DataSet();
           try
           {
               conn.Open();
               cmd = new MySqlCommand();
               cmd.Connection = conn;
               cmd.CommandType = CommandType.Text;
               cmd.CommandText = "SELECT * FROM doctors";
               MySqlDataAdapter mdap = new MySqlDataAdapter(cmd);
               mdap.Fill(ds, "doctors");
               conn.Close();
           }
           catch (MySqlException)
           {

           }
           return ds;
       }

       public bool insertData(
           String name,
           String address,
           String phone,
           String specialist
           )
       {
           Boolean stat = false;
           try
           {
               conn.Open();
               cmd = new MySqlCommand();
               cmd.Connection = conn;
               cmd.CommandType = CommandType.Text;
               cmd.CommandText = "INSERT INTO doctors VALUES ('','" + name + "','" + address + "','" + phone + "','" + specialist + "')";
               cmd.ExecuteNonQuery();
               stat = true;
               conn.Close();
           }
           catch (MySqlException) { }

           return stat;
       }

       public bool deleteData(string id)
       {
           Boolean stat = false;
           try
           {
               conn.Open();
               cmd = new MySqlCommand();
               cmd.Connection = conn;
               cmd.CommandType = CommandType.Text;
               cmd.CommandText = "DELETE FROM doctors WHERE id='" + id + "'";
               cmd.ExecuteNonQuery();
               stat = true;
               conn.Close();
           }
           catch (MySqlException) { }
           return stat;
       }

       public bool updateData(Doctor d, string id)
       {
           Boolean stat = false;
           try
           {
               conn.Open();
               cmd = new MySqlCommand();
               cmd.Connection = conn;
               cmd.CommandType = CommandType.Text;
               cmd.CommandText = "UPDATE doctors SET name='" + d.Name + "', address='" + d.Address + "',phone='" + d.Phone + "',specialist='" + d.Specialist + "' WHERE id='" + id + "'";
               cmd.ExecuteNonQuery();
               stat = true;
               conn.Close();
           }
           catch (MySqlException) { }
           return stat;
       }
 

   }

    
}
