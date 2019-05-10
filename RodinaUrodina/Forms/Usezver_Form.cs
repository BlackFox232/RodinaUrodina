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
    public partial class Usezver_Form : Form
    {
        public Usezver_Form()
        {
            InitializeComponent();
        }

        private void Uzv_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/im?media=&sel=143530677");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contacts contacts = new Contacts();
            contacts.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyTours myTours = new MyTours();
            myTours.ShowDialog();
            
        }
    }
}
