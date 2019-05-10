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
        private Bd_Interface bd_Interface = new Bd_Interface();
        int id = 1;
        public MyTours()
        {
            InitializeComponent();
        }

        private void MyTours_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            bd_Interface.ReturnAdapter("SELECT * FROM Tours");
            SqlDataAdapter dataAdapter = bd_Interface.ReturnAdapter("SELECT * FROM Tours");
            dataAdapter.Fill(ds, "User");
            toursDataGridView.DataSource = ds.Tables["Tours"];


        }
    }
}
