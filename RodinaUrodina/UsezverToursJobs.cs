using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace RodinaUrodina
{
    public class UsezverToursJobs : UsezverJobs
    {
       

        public DataTable GetAllTours()
        {
            DataSet ds = new DataSet();


            Bd_Interface.ReturnAdapter($"SELECT * FROM Tours ").Fill(ds, "Tours");

            return ds.Tables["Tours"];
        }
        public void ReservationTour(int userId,int tourId)
        {
            Bd_Interface.MakeQuery($"Insert INTO info_tours(Client_id,Tour_id,Date_reservation) VALUES ({userId},{tourId},CURRENT_TIMESTAMP)");
        }
    }
}