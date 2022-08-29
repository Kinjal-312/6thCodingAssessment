using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DALayer
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();

        public void Insert(int id, string name, string author, string publisher, decimal price)
        {
            conn = new SqlConnection("Server = NAG1-LHP-N76227;Database = BookDatabase;Integrated Security = SSPI");
            cmd = new SqlCommand("InsertIntoBookDetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Author", author);
            cmd.Parameters.AddWithValue("@Publisher", publisher);
            cmd.Parameters.AddWithValue("@Price", price);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int id)
        {
            conn = new SqlConnection("Server = DEL1-LHP-N82146;Database = Week6;Integrated Security = SSPI");
            cmd = new SqlCommand("DeleteBook", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(int id, string name, string author, string publisher, decimal price)
        {
            conn = new SqlConnection("Server = DEL1-LHP-N82146;Database = Week6;Integrated Security = SSPI");
            cmd = new SqlCommand("UpdateBook", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Author", author);
            cmd.Parameters.AddWithValue("@Publisher", publisher);
            cmd.Parameters.AddWithValue("@Price", price);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
