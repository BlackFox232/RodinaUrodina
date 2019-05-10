using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RodinaUrodina
{
    public class Bd_Interface
    {
        public const string connectionString = "Data Source = DESKTOP-MDU4BGA\\SQLEXPRESS; Initial Catalog = RodinaUrodina; Integrated Security = True";
        public readonly SqlConnection connection = new SqlConnection(connectionString);
        public readonly SqlCommand command = new SqlCommand();

        public SqlDataAdapter ReturnAdapter(string query)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            return dataAdapter;
        }
    }
}