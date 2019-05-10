using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RodinaUrodina
{
    static class Program
    {
        enum TransitionBetweenForms
        {
            Authorization,
            Registration,
            Admin_Form,
            Economic_Info,
            Info_Tour,
            Requests,
            Tours,
            Usezver_Form,
            Usezver_Info
        }


        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);





            Application.Run(new Authorization());






        }
    }
}
