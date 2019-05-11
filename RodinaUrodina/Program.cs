using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace RodinaUrodina
{
    static class Program
    {
        public enum Forms
        {
            Admin_Form,
            Economic_Info,
            FormCheckIn,
            FormLogIn,
            Info_Tour,
            MyRequest,
            Tours,
            Usezver_Form,
            Usezver_Info,
            Contacts,
            MyTours
        }

        public static Forms SelectedForm { get; set; } = Forms.FormLogIn;
        public static bool IsClose { get; set; }

        public static int UserId { get; set; }


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

                #region Run selected form
                switch (SelectedForm)
                {

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

                    case Forms.FormCheckIn:
                        {
                            Application.Run(new FormCheckIn());
                            break;
                        }

                    case Forms.FormLogIn:
                        {
                            Application.Run(new FormLogIn());
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

                }
                #endregion

                if (IsClose)
                    break;
            } 
        }


        public static string GetHash(string Data)
        {
            using (SHA512 SHA512Hash = SHA512.Create())
            {
                byte[] bytes = SHA512Hash.ComputeHash(Encoding.UTF8.GetBytes(Data));
  
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
