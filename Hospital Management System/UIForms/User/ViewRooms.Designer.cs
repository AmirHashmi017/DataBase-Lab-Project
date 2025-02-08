namespace AMS.UIForms.User
{
    partial class ViewRooms
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
            this.label1 = new System.Windows.Forms.Label();
            this.RoomsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 38F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(276, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 94);
            this.label1.TabIndex = 56;
            this.label1.Text = "View Alotted Rooms";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoomsGrid
            // 
            this.RoomsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RoomsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsGrid.Location = new System.Drawing.Point(240, 341);
            this.RoomsGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoomsGrid.Name = "RoomsGrid";
            this.RoomsGrid.ReadOnly = true;
            this.RoomsGrid.RowHeadersWidth = 51;
            this.RoomsGrid.RowTemplate.Height = 24;
            this.RoomsGrid.Size = new System.Drawing.Size(915, 366);
            this.RoomsGrid.TabIndex = 57;
            this.RoomsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomsGrid_CellContentClick);
            // 
            // ViewRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1176, 958);
            this.Controls.Add(this.RoomsGrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewRooms";
            this.Text = "ViewRooms";
            this.Load += new System.EventHandler(this.ViewRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RoomsGrid;
    }
}