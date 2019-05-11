using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace RodinaUrodina
{
    public partial class FormCheckIn : Form
    {
        public FormCheckIn()
        {
            InitializeComponent();            
        }


        #region Methods   

        void CreateNewAccount()
        {
            if (PassTB.Text != RepeatPassTB.Text)
            {
                WrongPass();
                return;
            }

            if (IsWrongLog())
            {
                WrongLog();
                return;
            }

            string Pass = Program.GetHash(PassTB.Text);
            Bd_Interface.MakeQuery($"Insert INTO Accounts(Login,Pass,Adm,Date,Deleted) VALUES ('{LogTB.Text}','{Pass}',0,CURRENT_TIMESTAMP, 0)");

            CorrectLogPass();
        }

        bool IsWrongLog()
        {
            string query = $"Select * from Accounts Where Login = '{LogTB.Text}'";

            DataTable DTable = new DataTable();
            Bd_Interface.ReturnAdapter(query).Fill(DTable);

            if (DTable.Rows.Count == 0)
                return false;

            return true;
        }

        void WrongPass()
        {
            PassTB.Text = "Пароль";                    //обновление полей
            PassTB.ForeColor = Color.Silver;
            PassTB.PasswordChar = '\0';

            RepeatPassTB.Text = "Повторите пароль";
            RepeatPassTB.ForeColor = Color.Silver;
            RepeatPassTB.PasswordChar = '\0';

            MessageBox.Show("Пароли не совпадают!", "Ошибка!");
        }

        void WrongLog()
        {
            LogTB.Text = "Логин";     //обновление поля логина
            LogTB.ForeColor = Color.Silver;

            MessageBox.Show("Такой пользователь уже существует!", "Ошибка!");
        }

        void CorrectLogPass()
        {
            MessageBox.Show("Регистрация выполнена успешно.", "Готово!");

            Program.SelectedForm = Program.Forms.FormLogIn;
            Program.IsClose = false;
            Close();
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

        #region TextBoxRepeatPass
        private void TextBoxRepeatPass_Enter(object sender, EventArgs e)
        {
            if (RepeatPassTB.Text == "Повторите пароль")
            {
                RepeatPassTB.Text = "";
                RepeatPassTB.ForeColor = Color.Black;
                RepeatPassTB.PasswordChar = '*';
            }
        }

        private void TextBoxRepeatPass_Leave(object sender, EventArgs e)
        {
            if (RepeatPassTB.Text == "")
            {
                RepeatPassTB.Text = "Повторите пароль";
                RepeatPassTB.ForeColor = Color.Silver;
                RepeatPassTB.PasswordChar = '\0';
            }
        }
        #endregion

        #endregion


        #region Events

        #region ButtonContinue
        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            CreateNewAccount();
        }

        private void ButtonContinue_MouseEnter(object sender, EventArgs e)
        {
            ButtonContinue.BackgroundImage = Properties.Resources.CheckInInFormPut;
            ButtonContinue.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtonContinue_MouseLeave(object sender, EventArgs e)
        {
            ButtonContinue.BackgroundImage = Properties.Resources.CheckInInFormBasic;
        }

        private void ButtonContinue_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonContinue.BackgroundImage = Properties.Resources.CheckInInFormPress;
            ButtonContinue.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void ButtonContinue_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonContinue.BackgroundImage = Properties.Resources.CheckInInFormPut;
        }
        #endregion


        #region ButtonCancel
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Program.SelectedForm = Program.Forms.FormLogIn;
            Program.IsClose = false;
            Close();
        }

        private void ButtonCancel_MouseEnter(object sender, EventArgs e)
        {
            ButtonCancel.BackgroundImage = Properties.Resources.ButtonCancelPut;
            ButtonCancel.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtonCancel_MouseLeave(object sender, EventArgs e)
        {
            ButtonCancel.BackgroundImage = Properties.Resources.ButtonCancel;
        }

        private void ButtonCancel_MouseDown(object sender, MouseEventArgs e)
        {            
            ButtonCancel.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }
        #endregion

        #endregion        
    }
}
