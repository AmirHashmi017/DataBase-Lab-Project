namespace AMS.UIForms.User
{
    partial class TakeAppointment
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
            this.AppointmentGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SpecCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DoctorCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dateCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TimeCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IDTxt = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentGrid
            // 
            this.AppointmentGrid.BackgroundColor = System.Drawing.Color.White;
            this.AppointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentGrid.Location = new System.Drawing.Point(221, 648);
            this.AppointmentGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppointmentGrid.Name = "AppointmentGrid";
            this.AppointmentGrid.ReadOnly = true;
            this.AppointmentGrid.RowHeadersWidth = 51;
            this.AppointmentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentGrid.Size = new System.Drawing.Size(915, 258);
            this.AppointmentGrid.TabIndex = 58;
            this.AppointmentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 38F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(301, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 94);
            this.label1.TabIndex = 57;
            this.label1.Text = "Take Appointment";
            // 
            // SpecCombo
            // 
            this.SpecCombo.BackColor = System.Drawing.Color.Transparent;
            this.SpecCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SpecCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SpecCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SpecCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SpecCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SpecCombo.ItemHeight = 30;
            this.SpecCombo.Location = new System.Drawing.Point(663, 238);
            this.SpecCombo.Name = "SpecCombo";
            this.SpecCombo.Size = new System.Drawing.Size(266, 36);
            this.SpecCombo.TabIndex = 101;
            this.SpecCombo.SelectedIndexChanged += new System.EventHandler(this.NurseCombo_SelectedIndexChanged);
            // 
            // DoctorCombo
            // 
            this.DoctorCombo.BackColor = System.Drawing.Color.Transparent;
            this.DoctorCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DoctorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoctorCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DoctorCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DoctorCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DoctorCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DoctorCombo.ItemHeight = 30;
            this.DoctorCombo.Location = new System.Drawing.Point(663, 316);
            this.DoctorCombo.Name = "DoctorCombo";
            this.DoctorCombo.Size = new System.Drawing.Size(266, 36);
            this.DoctorCombo.TabIndex = 100;
            this.DoctorCombo.SelectedIndexChanged += new System.EventHandler(this.DepartmentCombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(352, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 33);
            this.label5.TabIndex = 99;
            this.label5.Text = "Doctor Name and ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(357, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 33);
            this.label2.TabIndex = 98;
            this.label2.Text = "Doctor Specialization:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(352, 402);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 33);
            this.label8.TabIndex = 103;
            this.label8.Text = "Appointment Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(352, 482);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 33);
            this.label4.TabIndex = 102;
            this.label4.Text = "Appointment Time:";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(877, 555);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(244, 69);
            this.guna2GradientButton1.TabIndex = 106;
            this.guna2GradientButton1.Text = "Take Appointment";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // dateCombo
            // 
            this.dateCombo.BackColor = System.Drawing.Color.Transparent;
            this.dateCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dateCombo.ItemHeight = 30;
            this.dateCombo.Location = new System.Drawing.Point(663, 399);
            this.dateCombo.Name = "dateCombo";
            this.dateCombo.Size = new System.Drawing.Size(266, 36);
            this.dateCombo.TabIndex = 107;
            this.dateCombo.SelectedIndexChanged += new System.EventHandler(this.dateCombo_SelectedIndexChanged);
            // 
            // TimeCombo
            // 
            this.TimeCombo.BackColor = System.Drawing.Color.Transparent;
            this.TimeCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TimeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TimeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TimeCombo.ItemHeight = 30;
            this.TimeCombo.Location = new System.Drawing.Point(663, 482);
            this.TimeCombo.Name = "TimeCombo";
            this.TimeCombo.Size = new System.Drawing.Size(266, 36);
            this.TimeCombo.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(357, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 33);
            this.label3.TabIndex = 109;
            this.label3.Text = "Appointment ID:";
            // 
            // IDTxt
            // 
            this.IDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTxt.DefaultText = "";
            this.IDTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IDTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTxt.Location = new System.Drawing.Point(663, 168);
            this.IDTxt.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.PasswordChar = '\0';
            this.IDTxt.PlaceholderText = "";
            this.IDTxt.SelectedText = "";
            this.IDTxt.Size = new System.Drawing.Size(266, 49);
            this.IDTxt.TabIndex = 110;
            // 
            // TakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1176, 958);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeCombo);
            this.Controls.Add(this.dateCombo);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SpecCombo);
            this.Controls.Add(this.DoctorCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AppointmentGrid);
            this.Controls.Add(this.label1);
            this.Name = "TakeAppointment";
            this.Text = "TakeAppointment";
            this.Load += new System.EventHandler(this.TakeAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppointmentGrid;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox SpecCombo;
        private Guna.UI2.WinForms.Guna2ComboBox DoctorCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2ComboBox dateCombo;
        private Guna.UI2.WinForms.Guna2ComboBox TimeCombo;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox IDTxt;
    }
}