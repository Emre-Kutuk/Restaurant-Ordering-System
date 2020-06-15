namespace ChapeauUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.usernametest = new System.Windows.Forms.Label();
            this.LoginButton = new ChapeauUserControl.ButtonBase();
            this.textBody1 = new ChapeauUserControl.Elements.TextBody();
            this.textBody2 = new ChapeauUserControl.Elements.TextBody();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.passwordinput = new System.Windows.Forms.TextBox();
            this.usernameinput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(323, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 201);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox1.BackgroundImage")));
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(693, 471);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(23, 23);
            this.checkBox1.TabIndex = 43;
            this.checkBox1.Text = " .";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // usernametest
            // 
            this.usernametest.AutoSize = true;
            this.usernametest.Location = new System.Drawing.Point(467, 505);
            this.usernametest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernametest.Name = "usernametest";
            this.usernametest.Size = new System.Drawing.Size(0, 13);
            this.usernametest.TabIndex = 42;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Arial", 12F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.IsOutline = false;
            this.LoginButton.Location = new System.Drawing.Point(325, 551);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(364, 53);
            this.LoginButton.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.LoginButton.TabIndex = 41;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // textBody1
            // 
            this.textBody1.AutoSize = true;
            this.textBody1.Font = new System.Drawing.Font("Arial", 13F);
            this.textBody1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.textBody1.Location = new System.Drawing.Point(322, 367);
            this.textBody1.Name = "textBody1";
            this.textBody1.Size = new System.Drawing.Size(92, 21);
            this.textBody1.TabIndex = 45;
            this.textBody1.Text = "Username";
            // 
            // textBody2
            // 
            this.textBody2.AutoSize = true;
            this.textBody2.Font = new System.Drawing.Font("Arial", 13F);
            this.textBody2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.textBody2.Location = new System.Drawing.Point(322, 447);
            this.textBody2.Name = "textBody2";
            this.textBody2.Size = new System.Drawing.Size(89, 21);
            this.textBody2.TabIndex = 46;
            this.textBody2.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 5);
            this.panel1.TabIndex = 47;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // passwordinput
            // 
            this.passwordinput.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordinput.Location = new System.Drawing.Point(325, 470);
            this.passwordinput.Margin = new System.Windows.Forms.Padding(2);
            this.passwordinput.Name = "passwordinput";
            this.passwordinput.Size = new System.Drawing.Size(364, 26);
            this.passwordinput.TabIndex = 38;
            this.passwordinput.UseSystemPasswordChar = true;
            // 
            // usernameinput
            // 
            this.usernameinput.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameinput.Location = new System.Drawing.Point(326, 395);
            this.usernameinput.Margin = new System.Windows.Forms.Padding(2);
            this.usernameinput.Name = "usernameinput";
            this.usernameinput.Size = new System.Drawing.Size(363, 26);
            this.usernameinput.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBody2);
            this.Controls.Add(this.textBody1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.usernametest);
            this.Controls.Add(this.passwordinput);
            this.Controls.Add(this.usernameinput);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label usernametest;
        private ChapeauUserControl.ButtonBase LoginButton;
        private ChapeauUserControl.Elements.TextBody textBody1;
        private ChapeauUserControl.Elements.TextBody textBody2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox passwordinput;
        private System.Windows.Forms.TextBox usernameinput;
    }
}

