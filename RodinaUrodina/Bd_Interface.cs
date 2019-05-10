using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RodinaUrodina
{
    public class Bd_Interface : DbContext
    {
        public const string connectionString = "Data Source = BLACKFOX232;" +
            " Initial Catalog = RodinaUrodina;" +
            " Integrated Security = True";
        public readonly SqlConnection connection = new SqlConnection(connectionString);
        public readonly SqlCommand command = new SqlCommand();

        public Bd_Interface() : base(connectionString) { } 
        

        public SqlDataAdapter ReturnAdapter(string query)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            return dataAdapter;
        }

        public void MakeQuery(string query)
        {

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            try
            {

            }
            catch
            {

            }
            finally
            {
                reader.Close();
            }

        }
    }
}