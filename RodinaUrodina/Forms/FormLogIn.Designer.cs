namespace RodinaUrodina
{
    partial class FormLogIn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonCheckIn = new System.Windows.Forms.Button();
            this.ButtonLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogTB
            // 
            this.LogTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTB.BackColor = System.Drawing.Color.White;
            this.LogTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogTB.ForeColor = System.Drawing.Color.Silver;
            this.LogTB.Location = new System.Drawing.Point(305, 240);
            this.LogTB.Margin = new System.Windows.Forms.Padding(0);
            this.LogTB.Name = "LogTB";
            this.LogTB.Size = new System.Drawing.Size(350, 26);
            this.LogTB.TabIndex = 2;
            this.LogTB.Text = "Логин";
            this.LogTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogTB.Enter += new System.EventHandler(this.TextBoxLog_Enter);
            this.LogTB.Leave += new System.EventHandler(this.TextBoxLog_Leave);
            // 
            // PassTB
            // 
            this.PassTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassTB.BackColor = System.Drawing.Color.White;
            this.PassTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTB.ForeColor = System.Drawing.Color.Silver;
            this.PassTB.Location = new System.Drawing.Point(305, 280);
            this.PassTB.Margin = new System.Windows.Forms.Padding(0);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(350, 26);
            this.PassTB.TabIndex = 3;
            this.PassTB.Text = "Пароль";
            this.PassTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassTB.Enter += new System.EventHandler(this.TextBoxPass_Enter);
            this.PassTB.Leave += new System.EventHandler(this.TextBoxPass_Leave);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Transparent;
            this.ButtonExit.BackgroundImage = global::RodinaUrodina.Properties.Resources.ButtonExit;
            this.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExit.Location = new System.Drawing.Point(880, 5);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(70, 30);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            this.ButtonExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonExit_MouseDown);
            this.ButtonExit.MouseEnter += new System.EventHandler(this.ButtonExit_MouseEnter);
            this.ButtonExit.MouseLeave += new System.EventHandler(this.ButtonExit_MouseLeave);
            // 
            // ButtonCheckIn
            // 
            this.ButtonCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCheckIn.BackgroundImage = global::RodinaUrodina.Properties.Resources.CheckInBlack;
            this.ButtonCheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCheckIn.FlatAppearance.BorderSize = 0;
            this.ButtonCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCheckIn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCheckIn.Location = new System.Drawing.Point(440, 370);
            this.ButtonCheckIn.Name = "ButtonCheckIn";
            this.ButtonCheckIn.Size = new System.Drawing.Size(80, 20);
            this.ButtonCheckIn.TabIndex = 1;
            this.ButtonCheckIn.UseVisualStyleBackColor = false;
            this.ButtonCheckIn.Click += new System.EventHandler(this.ButtonCheckIn_Click);
            this.ButtonCheckIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonCheckIn_MouseDown);
            this.ButtonCheckIn.MouseEnter += new System.EventHandler(this.ButtonCheckIn_MouseEnter);
            this.ButtonCheckIn.MouseLeave += new System.EventHandler(this.ButtonCheckIn_MouseLeave);
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLogIn.BackgroundImage = global::RodinaUrodina.Properties.Resources.ButtonLogin;
            this.ButtonLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonLogIn.CausesValidation = false;
            this.ButtonLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogIn.FlatAppearance.BorderSize = 0;
            this.ButtonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLogIn.Location = new System.Drawing.Point(380, 330);
            this.ButtonLogIn.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(200, 35);
            this.ButtonLogIn.TabIndex = 0;
            this.ButtonLogIn.UseVisualStyleBackColor = false;
            this.ButtonLogIn.Click += new System.EventHandler(this.ButtonLogIn_Click);
            this.ButtonLogIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonLogIn_MouseDown);
            this.ButtonLogIn.MouseEnter += new System.EventHandler(this.ButtonLogIn_MouseEnter);
            this.ButtonLogIn.MouseLeave += new System.EventHandler(this.ButtonLogIn_MouseLeave);
            this.ButtonLogIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonLogIn_MouseUp);
            // 
            // FormLogIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.LogTB);
            this.Controls.Add(this.ButtonCheckIn);
            this.Controls.Add(this.ButtonLogIn);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogIn;
        private System.Windows.Forms.Button ButtonCheckIn;
        private System.Windows.Forms.TextBox LogTB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Button ButtonExit;
    }
}

