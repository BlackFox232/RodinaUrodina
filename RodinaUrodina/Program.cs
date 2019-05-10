using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RodinaUrodina
{
    static class Program
    {
        public enum Forms
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

        public static Forms SelectedForm { get; set; } = Forms.Authorization;
        public static bool IsClose { get; set } = false;


        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            while (true)
            {
                switch (SelectedForm)
                {
                    case Forms.Authorization:
                        {
                            Application.Run(new Authorization());
                            break;
                        }

                    case Forms.Registration:
                        {
                            Application.Run(new Registration());
                            break;
                        }

                    case Forms.Admin_Form:
                        {
                            Application.Run(new Admin_Form());
                            break;
                        }

                    case Forms.Economic_Info:
                        {
                            Application.Run(new Economic_Info());
                            break;
                        }

                    case Forms.Info_Tour:
                        {
                            Application.Run(new Info_Tour());
                            break;
                        }

                    case Forms.Requests:
                        {
                            Application.Run(new Requests());
                            break;
                        }

                    case Forms.Tours:
                        {
                            Application.Run(new Tours());
                            break;
                        }

                    case Forms.Usezver_Form:
                        {
                            Application.Run(new Usezver_Form());
                            break;
                        }

                    case Forms.Usezver_Info:
                        {
                            Application.Run(new Usezver_Info());
                            break;
                        }

                    default:
                        break;
                }

                if (IsClose)
                    break;
            }


            Application.Run(new Uzv());

            




        }
    }
}
