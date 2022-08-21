using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class DAL
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();

        public void Insert(string id, string name, string city, string email)
        {
            conn = new SqlConnection("Server = DEL1-LHP-N82143\\MSSQLSERVER01;Database = Week5;Integrated Security = SSPI");
            cmd = new SqlCommand("InsertIntoStudent",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Email", email);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(string id)
        {
            conn = new SqlConnection("Server = DEL1-LHP-N82143\\MSSQLSERVER01;Database = Week5;Integrated Security = SSPI");
            cmd = new SqlCommand("DeleteStudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(string id, string name, string city, string email)
        {
            conn = new SqlConnection("Server = DEL1-LHP-N82143\\MSSQLSERVER01;Database = Week5;Integrated Security = SSPI");
            cmd = new SqlCommand("UpdateStudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Email", email);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
