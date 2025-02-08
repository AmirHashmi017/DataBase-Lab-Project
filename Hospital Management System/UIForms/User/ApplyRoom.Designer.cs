namespace AMS.UIForms.User
{
    partial class ApplyRoom
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomCombo = new System.Windows.Forms.ComboBox();
            this.applyBtn = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(607, 94);
            this.label1.TabIndex = 57;
            this.label1.Text = "Apply For Room";
            // 
            // RoomsGrid
            // 
            this.RoomsGrid.AllowUserToAddRows = false;
            this.RoomsGrid.AllowUserToDeleteRows = false;
            this.RoomsGrid.AllowUserToResizeColumns = false;
            this.RoomsGrid.AllowUserToResizeRows = false;
            this.RoomsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RoomsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsGrid.Location = new System.Drawing.Point(236, 274);
            this.RoomsGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoomsGrid.Name = "RoomsGrid";
            this.RoomsGrid.ReadOnly = true;
            this.RoomsGrid.RowHeadersWidth = 51;
            this.RoomsGrid.RowTemplate.Height = 24;
            this.RoomsGrid.Size = new System.Drawing.Size(915, 366);
            this.RoomsGrid.TabIndex = 58;
            this.RoomsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomsGrid_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(231, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 32);
            this.label3.TabIndex = 70;
            this.label3.Text = "Available Rooms:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(263, 690);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 32);
            this.label2.TabIndex = 71;
            this.label2.Text = "Select RoomID:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // roomCombo
            // 
            this.roomCombo.FormattingEnabled = true;
            this.roomCombo.Location = new System.Drawing.Point(465, 690);
            this.roomCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomCombo.Name = "roomCombo";
            this.roomCombo.Size = new System.Drawing.Size(172, 28);
            this.roomCombo.TabIndex = 72;
            // 
            // applyBtn
            // 
            this.applyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.applyBtn.BackColor = System.Drawing.Color.Navy;
            this.applyBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.ForeColor = System.Drawing.Color.White;
            this.applyBtn.Location = new System.Drawing.Point(892, 680);
            this.applyBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(161, 54);
            this.applyBtn.TabIndex = 73;
            this.applyBtn.Text = "Take Room";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // ApplyRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1176, 958);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.roomCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RoomsGrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ApplyRoom";
            this.Text = "ApplyRoom";
            this.Load += new System.EventHandler(this.ApplyRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RoomsGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roomCombo;
        private System.Windows.Forms.Button applyBtn;
    }
}