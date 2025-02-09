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
            this.AppGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AppGrid
            // 
            this.AppGrid.BackgroundColor = System.Drawing.Color.White;
            this.AppGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppGrid.Location = new System.Drawing.Point(244, 338);
            this.AppGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppGrid.Name = "AppGrid";
            this.AppGrid.ReadOnly = true;
            this.AppGrid.RowHeadersWidth = 51;
            this.AppGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppGrid.Size = new System.Drawing.Size(915, 258);
            this.AppGrid.TabIndex = 56;
            this.AppGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 38F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(312, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 94);
            this.label1.TabIndex = 55;
            this.label1.Text = "View Appointments";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // View_Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1176, 958);
            this.Controls.Add(this.AppGrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "View_Appointments";
            this.Text = "View_Appointments";
            this.Load += new System.EventHandler(this.View_Appointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppGrid;
        private System.Windows.Forms.Label label1;
    }
}