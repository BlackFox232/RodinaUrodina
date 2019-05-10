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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_persons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Current_number_persons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info_tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.toursDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toursDataGridView
            // 
            this.toursDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toursDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Number_persons,
            this.Place,
            this.Current_number_persons,
            this.Info_tour,
            this.Status});
            this.toursDataGridView.Location = new System.Drawing.Point(85, 114);
            this.toursDataGridView.Name = "toursDataGridView";
            this.toursDataGridView.RowTemplate.Height = 24;
            this.toursDataGridView.Size = new System.Drawing.Size(743, 220);
            this.toursDataGridView.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Number_persons
            // 
            this.Number_persons.HeaderText = "Number_persons";
            this.Number_persons.Name = "Number_persons";
            // 
            // Place
            // 
            this.Place.HeaderText = "Place";
            this.Place.Name = "Place";
            // 
            // Current_number_persons
            // 
            this.Current_number_persons.HeaderText = "Current_number_persons";
            this.Current_number_persons.Name = "Current_number_persons";
            // 
            // Info_tour
            // 
            this.Info_tour.HeaderText = "Info_tour";
            this.Info_tour.Name = "Info_tour";
            // 
            // Status
            // 
            this.Status.HeaderText = "Price";
            this.Status.Name = "Status";
            // 
            // MyTours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_persons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current_number_persons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info_tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}