﻿using System;
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
        
        UsezverToursJobs usezverToursJobs = new UsezverToursJobs();
        public MyTours()
        {
            InitializeComponent();
        }

        private void MyTours_Load(object sender, EventArgs e)
        {
           
            toursDataGridView.DataSource = usezverToursJobs.GetMyTours(Program.UserId);


        }
    }
}
