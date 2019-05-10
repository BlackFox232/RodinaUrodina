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
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
        }

        private void requestsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rodinaUrodinaDataSet);

        }

        private void Requests_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rodinaUrodinaDataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.rodinaUrodinaDataSet.Requests);

        }
    }
}
