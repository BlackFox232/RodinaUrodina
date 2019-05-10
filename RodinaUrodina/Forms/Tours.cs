using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RodinaUrodina
{
    public partial class Tours : Form
    {
        Bd_Interface Bd_Interface = new Bd_Interface();
        ManagerToursJobs ManagerToursJobs = new ManagerToursJobs();

        public Tours()
        {
            InitializeComponent();
        }

        private void Tours_Load(object sender, EventArgs e)
        {
            toursDataGridView.DataSource = ManagerToursJobs.GetAllTours();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
