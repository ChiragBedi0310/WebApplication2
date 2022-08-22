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
        string connect = "Server = DEL1-LHP-N82143\\MSSQLSERVER01;Database = Week5;Integrated Security = SSPI";

        public void Insert(string id, string name, string city, string email)
        {
            conn = new SqlConnection(connect);
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
            conn = new SqlConnection(connect);
            cmd = new SqlCommand("DeleteStudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public bool Update(string id, string name, string city, string email)
        {
            if (GetNumberOfRecords() > 0)
            {
                conn = new SqlConnection(connect);
                cmd = new SqlCommand("UpdateStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Email", email);
                conn.Open();
                int n = cmd.ExecuteNonQuery();
                conn.Close();
                if (n > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public object Show()
        {
            conn = new SqlConnection(connect);
            cmd = new SqlCommand("StudentDetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable DT = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            return DT;
        }

        private int GetNumberOfRecords()
        {
            int count = -1;
            try
            {
                conn = new SqlConnection(connect);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select count(*) from Student", conn);

                count = (int)cmd.ExecuteScalar();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return count;
        }
    }
}
