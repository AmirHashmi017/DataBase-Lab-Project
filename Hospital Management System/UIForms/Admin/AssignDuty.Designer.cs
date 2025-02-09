namespace AMS.UIForms.Admin
{
    partial class AssignDuty
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
            this.DepartmentCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NurseCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Dutygrid = new System.Windows.Forms.DataGridView();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dutygrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 38F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(423, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 94);
            this.label1.TabIndex = 72;
            this.label1.Text = "Assign Duty";
            // 
            // DepartmentCombo
            // 
            this.DepartmentCombo.BackColor = System.Drawing.Color.Transparent;
            this.DepartmentCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DepartmentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepartmentCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepartmentCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DepartmentCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DepartmentCombo.ItemHeight = 30;
            this.DepartmentCombo.Location = new System.Drawing.Point(607, 342);
            this.DepartmentCombo.Name = "DepartmentCombo";
            this.DepartmentCombo.Size = new System.Drawing.Size(252, 36);
            this.DepartmentCombo.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(382, 359);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 33);
            this.label5.TabIndex = 95;
            this.label5.Text = "Department ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(393, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 33);
            this.label2.TabIndex = 94;
            this.label2.Text = "Nurse ID:";
            // 
            // NurseCombo
            // 
            this.NurseCombo.BackColor = System.Drawing.Color.Transparent;
            this.NurseCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NurseCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NurseCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NurseCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NurseCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NurseCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.NurseCombo.ItemHeight = 30;
            this.NurseCombo.Location = new System.Drawing.Point(607, 249);
            this.NurseCombo.Name = "NurseCombo";
            this.NurseCombo.Size = new System.Drawing.Size(252, 36);
            this.NurseCombo.TabIndex = 97;
            this.NurseCombo.SelectedIndexChanged += new System.EventHandler(this.NurseCombo_SelectedIndexChanged);
            // 
            // Dutygrid
            // 
            this.Dutygrid.BackgroundColor = System.Drawing.Color.White;
            this.Dutygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dutygrid.Location = new System.Drawing.Point(272, 558);
            this.Dutygrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dutygrid.Name = "Dutygrid";
            this.Dutygrid.ReadOnly = true;
            this.Dutygrid.RowHeadersWidth = 51;
            this.Dutygrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dutygrid.Size = new System.Drawing.Size(915, 258);
            this.Dutygrid.TabIndex = 100;
            this.Dutygrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dutygrid_CellContentClick);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(902, 456);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(190, 57);
            this.guna2GradientButton1.TabIndex = 98;
            this.guna2GradientButton1.Text = "Assign Duty";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // AssignDuty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 765);
            this.Controls.Add(this.Dutygrid);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.NurseCombo);
            this.Controls.Add(this.DepartmentCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssignDuty";
            this.Text = "AssignDuty";
            this.Load += new System.EventHandler(this.AssignDuty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dutygrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox DepartmentCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox NurseCombo;
        private System.Windows.Forms.DataGridView Dutygrid;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}