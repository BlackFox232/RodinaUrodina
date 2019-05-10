using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RodinaUrodina
{
    public class Bd_Interface
    {
        private const string connectionString = "Data Source = BLACKFOX232; Initial Catalog = RodinaUrodina; Integrated Security = True";
        public static readonly SqlConnection connection = new SqlConnection(connectionString);
        public static readonly SqlCommand command = new SqlCommand();

    }
}