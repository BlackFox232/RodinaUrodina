using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace RodinaUrodina
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }


        #region Methods   

        private int CheckLogPass(ref bool IsAdmin)
        {
            string Pass = Program.GetHash(PassTB.Text);
            string query = $"Select * from Accounts Where Login = '{LogTB.Text}' and Pass = '{Pass}'";

            DataTable DTable = new DataTable();
            Bd_Interface.ReturnAdapter(query).Fill(DTable);           

            if (DTable.Rows.Count == 1)
            {
                IsAdmin = (bool)DTable.Rows[0].ItemArray[3];
                return (int)DTable.Rows[0].ItemArray[0];
            }
            
            return 0;
        }
       
        void WrongLogPass()
        {
            ClearTB();

            MessageBox.Show("Неверный логин или пароль!", "Ошибка!");   //сообщение об ошибке
        }

        void CorrectLogPass(int Id, bool IsAdmin)
        {
            ClearTB();

            MessageBox.Show($"ID = {Id}");
            Program.UserId = Id;

            if(IsAdmin)
                Program.SelectedForm = Program.Forms.Admin_Form;
            else
                Program.SelectedForm = Program.Forms.Usezver_Form;

            Program.IsClose = false;
            Close();
        }

        void ClearTB()
        {
            LogTB.Text = "Логин";
            LogTB.ForeColor = Color.Silver;
            PassTB.Text = "Пароль";
            PassTB.ForeColor = Color.Silver;
            PassTB.PasswordChar = '\0';
        }

        #region TextBoxLog
        private void TextBoxLog_Enter(object sender, EventArgs e)
        {
            if (LogTB.Text == "Логин")
            {
                LogTB.Text = "";
                LogTB.ForeColor = Color.Black;
            }
        }

        private void TextBoxLog_Leave(object sender, EventArgs e)
        {
            if (LogTB.Text == "")
            {
                LogTB.Text = "Логин";
                LogTB.ForeColor = Color.Silver;
            }
        }
        #endregion

        #region TextBoxPass
        private void TextBoxPass_Enter(object sender, EventArgs e)
        {
            if (PassTB.Text == "Пароль")
            {
                PassTB.Text = "";
                PassTB.ForeColor = Color.Black;
                PassTB.PasswordChar = '*';
            }
        }

        private void TextBoxPass_Leave(object sender, EventArgs e)
        {
            if (PassTB.Text == "")
            {
                PassTB.Text = "Пароль";
                PassTB.ForeColor = Color.Silver;
                PassTB.PasswordChar = '\0';
            }
        }
        #endregion

        #endregion


        #region Events

        #region ButtonLogIn
        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            bool IsAdmin = false;

            int Id = CheckLogPass(ref IsAdmin);
            if (Id == 0)
            {
                WrongLogPass();
                return;
            }

            CorrectLogPass(Id, IsAdmin);
        }

        private void ButtonLogIn_MouseEnter(object sender, EventArgs e)
        {
            ButtonLogIn.BackgroundImage = Properties.Resources.ButtonPutLogin;
            ButtonLogIn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtonLogIn_MouseLeave(object sender, EventArgs e)
        {
            ButtonLogIn.BackgroundImage = Properties.Resources.ButtonLogin;
        }

        private void ButtonLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonLogIn.BackgroundImage = Properties.Resources.ButtonPressLogin;
            ButtonLogIn.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void ButtonLogIn_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonLogIn.BackgroundImage = Properties.Resources.ButtonPutLogin;
        }
        #endregion


        #region ButtonCheckIn
        private void ButtonCheckIn_Click(object sender, EventArgs e)
        {
            Program.SelectedForm = Program.Forms.FormCheckIn;
            Program.IsClose = false;
            Close();
        }

        private void ButtonCheckIn_MouseEnter(object sender, EventArgs e)
        {
            ButtonCheckIn.BackgroundImage = Properties.Resources.CheckInRed;
            ButtonCheckIn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtonCheckIn_MouseLeave(object sender, EventArgs e)
        {
            ButtonCheckIn.BackgroundImage = Properties.Resources.CheckInBlack;
        }

        private void ButtonCheckIn_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonCheckIn.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }
        #endregion


        #region ButtonExit
        private void ButtonExit_MouseEnter(object sender, EventArgs e)
        {
            ButtonExit.BackgroundImage = Properties.Resources.ButtonExitPut;
            ButtonExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtonExit_MouseLeave(object sender, EventArgs e)
        {
            ButtonExit.BackgroundImage = Properties.Resources.ButtonExit;
        }

        private void ButtonExit_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #endregion        
    }
}
