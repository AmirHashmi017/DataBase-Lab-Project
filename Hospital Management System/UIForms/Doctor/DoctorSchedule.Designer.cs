namespace AMS.UIForms.Doctor
{
    partial class DoctorSchedule
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
            this.ScheduleGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AddButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dateTxt = new System.Windows.Forms.DateTimePicker();
            this.starttimeTxt = new System.Windows.Forms.DateTimePicker();
            this.endtimeTxt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 38F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(270, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 94);
            this.label1.TabIndex = 56;
            this.label1.Text = "Add Doctor Schedule";
            // 
            // ScheduleGrid
            // 
            this.ScheduleGrid.BackgroundColor = System.Drawing.Color.White;
            this.ScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleGrid.Location = new System.Drawing.Point(232, 597);
            this.ScheduleGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScheduleGrid.Name = "ScheduleGrid";
            this.ScheduleGrid.ReadOnly = true;
            this.ScheduleGrid.RowHeadersWidth = 51;
            this.ScheduleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ScheduleGrid.Size = new System.Drawing.Size(915, 258);
            this.ScheduleGrid.TabIndex = 57;
            this.ScheduleGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightGrid_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(709, 254);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 33);
            this.label8.TabIndex = 62;
            this.label8.Text = "Schedule Date:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(709, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 61;
            this.label4.Text = "End Time:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(219, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 33);
            this.label3.TabIndex = 60;
            this.label3.Text = "Start Time:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(219, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 33);
            this.label2.TabIndex = 59;
            this.label2.Text = "Schedule ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IDTxt
            // 
            this.IDTxt.Animated = true;
            this.IDTxt.BorderColor = System.Drawing.Color.Black;
            this.IDTxt.BorderRadius = 10;
            this.IDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTxt.DefaultText = "";
            this.IDTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IDTxt.ForeColor = System.Drawing.Color.Black;
            this.IDTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTxt.Location = new System.Drawing.Point(400, 261);
            this.IDTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.PasswordChar = '\0';
            this.IDTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.IDTxt.PlaceholderText = "";
            this.IDTxt.SelectedText = "";
            this.IDTxt.Size = new System.Drawing.Size(274, 32);
            this.IDTxt.TabIndex = 58;
            this.IDTxt.TextChanged += new System.EventHandler(this.IDtxt_TextChanged);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2GradientButton2.BorderRadius = 10;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Location = new System.Drawing.Point(243, 482);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(158, 52);
            this.guna2GradientButton2.TabIndex = 67;
            this.guna2GradientButton2.Text = "Clear";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddButton.BorderRadius = 10;
            this.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddButton.FillColor = System.Drawing.Color.Green;
            this.AddButton.FillColor2 = System.Drawing.Color.SeaGreen;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(960, 482);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(158, 52);
            this.AddButton.TabIndex = 66;
            this.AddButton.Text = "Add";
            this.AddButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(916, 260);
            this.dateTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(266, 26);
            this.dateTxt.TabIndex = 65;
            this.dateTxt.ValueChanged += new System.EventHandler(this.Datetxt_ValueChanged);
            // 
            // starttimeTxt
            // 
            this.starttimeTxt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.starttimeTxt.Location = new System.Drawing.Point(400, 366);
            this.starttimeTxt.Name = "starttimeTxt";
            this.starttimeTxt.ShowUpDown = true;
            this.starttimeTxt.Size = new System.Drawing.Size(274, 26);
            this.starttimeTxt.TabIndex = 68;
            this.starttimeTxt.Value = new System.DateTime(2025, 2, 8, 17, 50, 0, 0);
            // 
            // endtimeTxt
            // 
            this.endtimeTxt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endtimeTxt.Location = new System.Drawing.Point(916, 365);
            this.endtimeTxt.Name = "endtimeTxt";
            this.endtimeTxt.ShowUpDown = true;
            this.endtimeTxt.Size = new System.Drawing.Size(266, 26);
            this.endtimeTxt.TabIndex = 69;
            // 
            // DoctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1235, 958);
            this.Controls.Add(this.endtimeTxt);
            this.Controls.Add(this.starttimeTxt);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.ScheduleGrid);
            this.Controls.Add(this.label1);
            this.Name = "DoctorSchedule";
            this.Text = "DoctorSchedule";
            this.Load += new System.EventHandler(this.DoctorSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ScheduleGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox IDTxt;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton AddButton;
        private System.Windows.Forms.DateTimePicker dateTxt;
        private System.Windows.Forms.DateTimePicker starttimeTxt;
        private System.Windows.Forms.DateTimePicker endtimeTxt;
    }
}