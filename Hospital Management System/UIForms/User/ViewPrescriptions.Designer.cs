namespace AMS.UIForms.User
{
    partial class ViewPrescriptions
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
            this.PrescriptionGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PrescriptionGrid
            // 
            this.PrescriptionGrid.BackgroundColor = System.Drawing.Color.White;
            this.PrescriptionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrescriptionGrid.Location = new System.Drawing.Point(227, 370);
            this.PrescriptionGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrescriptionGrid.Name = "PrescriptionGrid";
            this.PrescriptionGrid.ReadOnly = true;
            this.PrescriptionGrid.RowHeadersWidth = 51;
            this.PrescriptionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PrescriptionGrid.Size = new System.Drawing.Size(915, 258);
            this.PrescriptionGrid.TabIndex = 58;
            this.PrescriptionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrescriptionGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 38F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(311, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 94);
            this.label1.TabIndex = 57;
            this.label1.Text = "View Prescriptions";
            // 
            // ViewPrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1176, 958);
            this.Controls.Add(this.PrescriptionGrid);
            this.Controls.Add(this.label1);
            this.Name = "ViewPrescriptions";
            this.Text = "ViewPrescriptions";
            this.Load += new System.EventHandler(this.ViewPrescriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PrescriptionGrid;
        private System.Windows.Forms.Label label1;
    }
}