namespace RodinaUrodina
{
    partial class MyTours
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
            this.toursDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.toursDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toursDataGridView
            // 
            this.toursDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toursDataGridView.Location = new System.Drawing.Point(85, 114);
            this.toursDataGridView.Name = "toursDataGridView";
            this.toursDataGridView.RowTemplate.Height = 24;
            this.toursDataGridView.Size = new System.Drawing.Size(743, 220);
            this.toursDataGridView.TabIndex = 2;
            // 
            // MyTours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.toursDataGridView);
            this.Name = "MyTours";
            this.Text = "MyTours";
            this.Load += new System.EventHandler(this.MyTours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toursDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView toursDataGridView;
    }
}