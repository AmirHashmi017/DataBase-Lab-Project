namespace AMS.UIForms.Doctor
{
    partial class Write_Prescription
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
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AddButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.prescriptionGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DosageTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.medicineTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.remarksTxt = new System.Windows.Forms.RichTextBox();
            this.PatientCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionGrid)).BeginInit();
            this.SuspendLayout();
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
            this.guna2GradientButton2.Location = new System.Drawing.Point(219, 561);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(158, 52);
            this.guna2GradientButton2.TabIndex = 71;
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
            this.AddButton.Location = new System.Drawing.Point(999, 551);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(158, 52);
            this.AddButton.TabIndex = 70;
            this.AddButton.Text = "Add";
            this.AddButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // prescriptionGrid
            // 
            this.prescriptionGrid.BackgroundColor = System.Drawing.Color.White;
            this.prescriptionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescriptionGrid.Location = new System.Drawing.Point(219, 654);
            this.prescriptionGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prescriptionGrid.Name = "prescriptionGrid";
            this.prescriptionGrid.ReadOnly = true;
            this.prescriptionGrid.RowHeadersWidth = 51;
            this.prescriptionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prescriptionGrid.Size = new System.Drawing.Size(955, 258);
            this.prescriptionGrid.TabIndex = 69;
            this.prescriptionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prescriptionGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 38F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(353, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(704, 94);
            this.label1.TabIndex = 68;
            this.label1.Text = "Write Prescription";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(213, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 33);
            this.label2.TabIndex = 73;
            this.label2.Text = "Prescription ID:";
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
            this.IDTxt.Location = new System.Drawing.Point(439, 229);
            this.IDTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.PasswordChar = '\0';
            this.IDTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.IDTxt.PlaceholderText = "";
            this.IDTxt.SelectedText = "";
            this.IDTxt.Size = new System.Drawing.Size(274, 32);
            this.IDTxt.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(210, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 33);
            this.label3.TabIndex = 75;
            this.label3.Text = "Dosage:";
            // 
            // DosageTxt
            // 
            this.DosageTxt.Animated = true;
            this.DosageTxt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DosageTxt.BorderColor = System.Drawing.Color.Black;
            this.DosageTxt.BorderRadius = 10;
            this.DosageTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DosageTxt.DefaultText = "";
            this.DosageTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DosageTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DosageTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DosageTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DosageTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DosageTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DosageTxt.ForeColor = System.Drawing.Color.Black;
            this.DosageTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DosageTxt.Location = new System.Drawing.Point(439, 350);
            this.DosageTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DosageTxt.Name = "DosageTxt";
            this.DosageTxt.PasswordChar = '\0';
            this.DosageTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.DosageTxt.PlaceholderText = "";
            this.DosageTxt.SelectedText = "";
            this.DosageTxt.Size = new System.Drawing.Size(274, 32);
            this.DosageTxt.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(729, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 33);
            this.label4.TabIndex = 77;
            this.label4.Text = "Medicine:";
            // 
            // medicineTxt
            // 
            this.medicineTxt.Animated = true;
            this.medicineTxt.BorderColor = System.Drawing.Color.Black;
            this.medicineTxt.BorderRadius = 10;
            this.medicineTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medicineTxt.DefaultText = "";
            this.medicineTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.medicineTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.medicineTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medicineTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.medicineTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medicineTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.medicineTxt.ForeColor = System.Drawing.Color.Black;
            this.medicineTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.medicineTxt.Location = new System.Drawing.Point(888, 351);
            this.medicineTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.medicineTxt.Name = "medicineTxt";
            this.medicineTxt.PasswordChar = '\0';
            this.medicineTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.medicineTxt.PlaceholderText = "";
            this.medicineTxt.SelectedText = "";
            this.medicineTxt.Size = new System.Drawing.Size(274, 32);
            this.medicineTxt.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(210, 460);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 33);
            this.label5.TabIndex = 79;
            this.label5.Text = "Doctor Remarks:";
            // 
            // remarksTxt
            // 
            this.remarksTxt.Location = new System.Drawing.Point(439, 447);
            this.remarksTxt.Name = "remarksTxt";
            this.remarksTxt.Size = new System.Drawing.Size(723, 55);
            this.remarksTxt.TabIndex = 80;
            this.remarksTxt.Text = "";
            // 
            // PatientCombo
            // 
            this.PatientCombo.BackColor = System.Drawing.Color.Transparent;
            this.PatientCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PatientCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatientCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PatientCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PatientCombo.ItemHeight = 30;
            this.PatientCombo.Location = new System.Drawing.Point(893, 225);
            this.PatientCombo.Name = "PatientCombo";
            this.PatientCombo.Size = new System.Drawing.Size(269, 36);
            this.PatientCombo.TabIndex = 99;
            this.PatientCombo.SelectedIndexChanged += new System.EventHandler(this.PatientCombo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(729, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 33);
            this.label6.TabIndex = 98;
            this.label6.Text = "Patient ID:";
            // 
            // Write_Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1235, 958);
            this.Controls.Add(this.PatientCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.remarksTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.medicineTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DosageTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.prescriptionGrid);
            this.Controls.Add(this.label1);
            this.Name = "Write_Prescription";
            this.Text = "Write_Prescription";
            this.Load += new System.EventHandler(this.Write_Prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton AddButton;
        private System.Windows.Forms.DataGridView prescriptionGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox IDTxt;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox DosageTxt;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox medicineTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox remarksTxt;
        private Guna.UI2.WinForms.Guna2ComboBox PatientCombo;
        private System.Windows.Forms.Label label6;
    }
}