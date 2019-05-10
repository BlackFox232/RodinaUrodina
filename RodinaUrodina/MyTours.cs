using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RodinaUrodina
{
    
    public partial class MyTours : Form
    {
        
        public MyTours()
        {
            InitializeComponent();
        }

        private void MyTours_Load(object sender, EventArgs e)
        {
            
           
            
                Bd_Interface.connection.Open();

            Bd_Interface.command.CommandText = "SELECT * FROM Users";
            Bd_Interface.command.Connection = Bd_Interface.connection;
            
        }
    }
}
