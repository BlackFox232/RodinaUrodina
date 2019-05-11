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
        UsezverToursJobs usezverToursJobs = new UsezverToursJobs();

        public Tours()
        {
            InitializeComponent();
        }

        private void Tours_Load(object sender, EventArgs e)
        {
            toursDataGridView.DataSource = usezverToursJobs.GetAllTours();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usezverToursJobs.ReservationTour(Program.UserId, toursDataGridView.CurrentRow.Index+1);
           // usezverToursJobs.ChangeNumberPersons(toursDataGridView.CurrentRow.Index + 1);
        }
    }
}
