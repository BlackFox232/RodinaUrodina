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
        public Tours()
        {
            InitializeComponent();
        }

        private void toursBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.toursBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rodinaUrodinaDataSet);

        }

        private void Tours_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rodinaUrodinaDataSet.Tours". При необходимости она может быть перемещена или удалена.
            this.toursTableAdapter.Fill(this.rodinaUrodinaDataSet.Tours);

        }
    }
}
