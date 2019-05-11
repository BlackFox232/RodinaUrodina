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

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }


        // methods
        void WrongLogPass()
        {
            ClearTB();
             
              //сообщение об ошибке
        }

        void CorrectLogPass(int Id)
        { 
            ClearTB();
            
            Program.UserId = Id;

            Program.SelectedForm = Program.Forms.Admin_Form;
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

        private int CheckLogPass()
        {
            string Table = "Accounts";
            string query = $"Select * from {Table} Where Login = '{LogTB.Text}' and Pass = '{PassTB.Text}'";

            SqlDataAdapter Adapter = Bd_Interface.ReturnAdapter(query); 
            DataTable DTable = new DataTable();
            Adapter.Fill(DTable);
           
            if (DTable.Rows.Count == 1) 
                return (int)DTable.Rows[0].ItemArray[0];
            
            return 0;
        }

        #region ButtonLogIn
        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            int Id = CheckLogPass();
            if (Id == 0)
            {
                WrongLogPass();
                return;
            }

            CorrectLogPass(Id);
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
            Program.SelectedForm = Program.Forms.Registration;
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
    }
}
