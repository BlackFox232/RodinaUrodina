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
            MyRequest,
            Tours,
            Usezver_Form,
            Usezver_Info,
            Contacts,
            MyTours
        }
        //comment
        public static Forms SelectedForm { get; set; } = Forms.Authorization;
        public static bool IsClose { get; set; }


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
                IsClose = true;

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

                    case Forms.MyRequest:
                        {
                            Application.Run(new MyRequest());
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

                    case Forms.Contacts:
                        {
                            Application.Run(new Contacts());
                            break;
                        }

                    case Forms.MyTours:
                        {
                            Application.Run(new MyTours());
                            break;
                        }

                    default:
                        break;
                }

                if (IsClose)
                    break;
            }

            Application.Run(new Usezver_Form());    
        }
    }
}
