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

            Bd_Interface.ReturnAdapter($"SELECT * FROM Tours where Status = 1").Fill(ds, "Tours");

            return ds.Tables["Tours"];
        }

        public void ReservationTour(int userId, int tourId) => Bd_Interface.MakeQuery($"Insert INTO info_tours(Client_id,Tour_id,Date_reservation) VALUES ({userId},{tourId},CURRENT_TIMESTAMP)");

        public DataTable GetMyTours(int userId)
        {
            string query = $"SELECT dbo.Accounts.Login, dbo.info_tours.Client_id, " +
                    $"dbo.info_tours.Tour_id, dbo.Tours.Date, dbo.Tours.Number_persons, " +
                    $"dbo.Tours.Place, dbo.Tours.Current_number_persons, dbo.Tours.Info_tour" +
                $" FROM dbo.Accounts" +
                $" INNER JOIN dbo.info_tours ON dbo.Accounts.Id = dbo.info_tours.Tour_id" +
                $" INNER JOIN dbo.Tours ON dbo.info_tours.Tour_id = dbo.Tours.Id" +
                $" WHERE dbo.info_tours.Client_id = {userId}";

            DataSet ds = new DataSet();

            Bd_Interface.ReturnAdapter(query).Fill(ds, "View_1");

            return ds.Tables["View_1"];
        }

        public void ChangeNumberPersons(int tourId)
        {
            Bd_Interface.MakeQuery($"Update Tours SET Current_number_persons = Current_number_persons+1 WHERE Id = {tourId} IF (dbo.Tours.Current_number_persons = dbo.Tours.Number_persons) then BEGIN UPDATE Tours Set dbo.Tours.Status = 0 WHERE dbo.Tours.Id = {tourId} END");
            //Bd_Interface.MakeQuery($"CASE when dbo.Tours.Current_number_persons = dbo.Tours.Number_persons then UPDATE Tours Set dbo.Tours.Status = 0 WHERE dbo.Tours.Id = {tourId}");
                
        }
    }
}