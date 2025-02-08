namespace Skylines.UIForms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginbutton = new Guna.UI2.WinForms.Guna2Button();
            this.passwordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::AMS.Properties.Resources._lock;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(727, 198);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(345, 329);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 9;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 50;
            this.guna2CustomGradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2CustomGradientPanel1.BorderThickness = 50;
            this.guna2CustomGradientPanel1.Controls.Add(this.linkLabel1);
            this.guna2CustomGradientPanel1.Controls.Add(this.loginbutton);
            this.guna2CustomGradientPanel1.Controls.Add(this.passwordTxt);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.Controls.Add(this.idTxt);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Navy;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(216)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(98, 109);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(611, 566);
            this.guna2CustomGradientPanel1.TabIndex = 12;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(143, 349);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(342, 42);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Don\'t have an account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // loginbutton
            // 
            this.loginbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginbutton.BackColor = System.Drawing.Color.Transparent;
            this.loginbutton.BorderRadius = 30;
            this.loginbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginbutton.FillColor = System.Drawing.Color.DarkBlue;
            this.loginbutton.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Location = new System.Drawing.Point(375, 450);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(202, 56);
            this.loginbutton.TabIndex = 3;
            this.loginbutton.Text = "Log IN";
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTxt.BackColor = System.Drawing.Color.Transparent;
            this.passwordTxt.BorderRadius = 10;
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.DefaultText = "";
            this.passwordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.passwordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxt.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.White;
            this.passwordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxt.Location = new System.Drawing.Point(267, 221);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '\0';
            this.passwordTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.passwordTxt.PlaceholderText = "*************";
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.Size = new System.Drawing.Size(264, 51);
            this.passwordTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(93, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // idTxt
            // 
            this.idTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idTxt.BorderRadius = 10;
            this.idTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTxt.DefaultText = "";
            this.idTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.idTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTxt.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxt.ForeColor = System.Drawing.Color.White;
            this.idTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTxt.Location = new System.Drawing.Point(267, 105);
            this.idTxt.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.idTxt.Name = "idTxt";
            this.idTxt.PasswordChar = '\0';
            this.idTxt.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.idTxt.PlaceholderText = "Enter user id...";
            this.idTxt.SelectedText = "";
            this.idTxt.Size = new System.Drawing.Size(264, 48);
            this.idTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(93, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 90);
            this.label2.TabIndex = 5;
            this.label2.Text = "LOG IN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1105, 691);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Button loginbutton;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxt;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox idTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}