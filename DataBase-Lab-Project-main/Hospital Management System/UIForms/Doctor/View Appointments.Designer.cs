namespace AMS.UIForms.Doctor
{
    partial class View_Appointments
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
            this.FlightGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FlightGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightGrid
            // 
            this.FlightGrid.BackgroundColor = System.Drawing.Color.White;
            this.FlightGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightGrid.Location = new System.Drawing.Point(213, 273);
            this.FlightGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlightGrid.Name = "FlightGrid";
            this.FlightGrid.ReadOnly = true;
            this.FlightGrid.RowHeadersWidth = 51;
            this.FlightGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FlightGrid.Size = new System.Drawing.Size(813, 206);
            this.FlightGrid.TabIndex = 56;
            this.FlightGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 38F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(245, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 81);
            this.label1.TabIndex = 55;
            this.label1.Text = "View Appointments";
            // 
            // View_Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1045, 766);
            this.Controls.Add(this.FlightGrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "View_Appointments";
            this.Text = "View_Appointments";
            this.Load += new System.EventHandler(this.View_Appointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FlightGrid;
        private System.Windows.Forms.Label label1;
    }
}