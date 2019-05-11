namespace RodinaUrodina
{
    partial class FormCheckIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PassTB = new System.Windows.Forms.TextBox();
            this.LogTB = new System.Windows.Forms.TextBox();
            this.RepeatPassTB = new System.Windows.Forms.TextBox();
            this.ButtonContinue = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.PassTB.Location = new System.Drawing.Point(125, 140);
            this.PassTB.Margin = new System.Windows.Forms.Padding(0);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(350, 26);
            this.PassTB.TabIndex = 5;
            this.PassTB.Text = "Пароль";
            this.PassTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassTB.Enter += new System.EventHandler(this.TextBoxPass_Enter);
            this.PassTB.Leave += new System.EventHandler(this.TextBoxPass_Leave);
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
            this.LogTB.Location = new System.Drawing.Point(125, 100);
            this.LogTB.Margin = new System.Windows.Forms.Padding(0);
            this.LogTB.Name = "LogTB";
            this.LogTB.Size = new System.Drawing.Size(350, 26);
            this.LogTB.TabIndex = 4;
            this.LogTB.Text = "Логин";
            this.LogTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogTB.Enter += new System.EventHandler(this.TextBoxLog_Enter);
            this.LogTB.Leave += new System.EventHandler(this.TextBoxLog_Leave);
            // 
            // RepeatPassTB
            // 
            this.RepeatPassTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RepeatPassTB.BackColor = System.Drawing.Color.White;
            this.RepeatPassTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepeatPassTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPassTB.ForeColor = System.Drawing.Color.Silver;
            this.RepeatPassTB.Location = new System.Drawing.Point(125, 180);
            this.RepeatPassTB.Margin = new System.Windows.Forms.Padding(0);
            this.RepeatPassTB.Name = "RepeatPassTB";
            this.RepeatPassTB.Size = new System.Drawing.Size(350, 26);
            this.RepeatPassTB.TabIndex = 6;
            this.RepeatPassTB.Text = "Повторите пароль";
            this.RepeatPassTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RepeatPassTB.Enter += new System.EventHandler(this.TextBoxRepeatPass_Enter);
            this.RepeatPassTB.Leave += new System.EventHandler(this.TextBoxRepeatPass_Leave);
            // 
            // ButtonContinue
            // 
            this.ButtonContinue.BackColor = System.Drawing.Color.Transparent;
            this.ButtonContinue.BackgroundImage = global::RodinaUrodina.Properties.Resources.CheckInInFormBasic;
            this.ButtonContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonContinue.FlatAppearance.BorderSize = 0;
            this.ButtonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonContinue.Location = new System.Drawing.Point(170, 220);
            this.ButtonContinue.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonContinue.Name = "ButtonContinue";
            this.ButtonContinue.Size = new System.Drawing.Size(260, 40);
            this.ButtonContinue.TabIndex = 7;
            this.ButtonContinue.UseVisualStyleBackColor = false;
            this.ButtonContinue.Click += new System.EventHandler(this.ButtonContinue_Click);
            this.ButtonContinue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonContinue_MouseDown);
            this.ButtonContinue.MouseEnter += new System.EventHandler(this.ButtonContinue_MouseEnter);
            this.ButtonContinue.MouseLeave += new System.EventHandler(this.ButtonContinue_MouseLeave);
            this.ButtonContinue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonContinue_MouseUp);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCancel.BackgroundImage = global::RodinaUrodina.Properties.Resources.ButtonCancel;
            this.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.FlatAppearance.BorderSize = 0;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Location = new System.Drawing.Point(270, 263);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(60, 20);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            this.ButtonCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonCancel_MouseDown);
            this.ButtonCancel.MouseEnter += new System.EventHandler(this.ButtonCancel_MouseEnter);
            this.ButtonCancel.MouseLeave += new System.EventHandler(this.ButtonCancel_MouseLeave);
            // 
            // FormCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonContinue);
            this.Controls.Add(this.RepeatPassTB);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.LogTB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCheckIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox LogTB;
        private System.Windows.Forms.TextBox RepeatPassTB;
        private System.Windows.Forms.Button ButtonContinue;
        private System.Windows.Forms.Button ButtonCancel;
    }
}