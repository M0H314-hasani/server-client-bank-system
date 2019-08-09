using System;
using System.Data;
using System.Data.SqlClient;


namespace Server.Lib
{
    class DB
    {
        private SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader reader;
        
        public DB()
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + "\\db.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public DataTable getAll(string table)
        {
            DataTable dataTable = new DataTable();

            con.Open();
            adapt = new SqlDataAdapter("SELECT * FROM " + table, con);
            adapt.Fill(dataTable);
            con.Close();

            return dataTable;
        }

        public DataTable getById(string table, string targetId)
        {
            DataTable dataTable = new DataTable();

            con.Open();
            adapt = new SqlDataAdapter("SELECT * FROM " + table + " WHERE id=" + targetId, con);
            adapt.Fill(dataTable);
            con.Close();

            return dataTable;
        }

        public int insert(string table, string[] fields, object[] values)
        {
            string command = "INSERT INTO " + table + "(" + string.Join(",", fields) + ") VALUES(@" + string.Join(",@", fields) + "); SELECT CAST(scope_identity() AS int)";
            cmd = new SqlCommand(command, con);
            con.Open();

            for(int i=0; i < fields.Length; i++)
                cmd.Parameters.AddWithValue("@" + fields[i], values[i] ?? "");

           int  newID = (int)cmd.ExecuteScalar();
            con.Close();

            return newID;

        }

        public void update(string table, string targetId, string[] fields, object[] values)
        {
            string command = "UPDATE " + table + " SET ";
            for (int i=0; i < fields.Length; i++)
            {
                command += i == fields.Length-1 ? fields[i] + "='" + values[i] + "'" : fields[i] + "='" + values[i] + "',"; 
            }
            command += " WHERE id=" + targetId;

            cmd = new SqlCommand(command, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void delete(string table, int targetId)
        {
            string command = "DELETE "+ table +" WHERE id=" + targetId.ToString();
            cmd = new SqlCommand(command, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable query(string command)
        {
            DataTable dataTable = new DataTable();

            con.Open();
            adapt = new SqlDataAdapter(command, con);
            adapt.Fill(dataTable);
            con.Close();

            return dataTable;
     
        }

    }
}
