using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace RodinaUrodina
{
    public class ManagerToursJobs : ManagerJobs
    {

        public DataTable GetAllTours()
        {
            DataSet ds = new DataSet();

            Bd_Interface.ReturnAdapter($"SELECT * FROM Tours").Fill(ds, "Tours");

            return ds.Tables["Tours"];
        }
    }
}