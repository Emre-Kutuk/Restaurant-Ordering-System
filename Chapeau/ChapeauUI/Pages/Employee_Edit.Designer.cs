namespace ChapeauUI.Pages
{
    partial class Employee_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Edit));
            this.listEmployees = new System.Windows.Forms.ListView();
            this.textHeading1 = new ChapeauUserControl.Elements.TextHeading();
            this.btn_deleteEmployee = new ChapeauUserControl.ButtonBase();
            this.name_txt = new ChapeauUserControl.Elements.Form.Input();
            this.password_txt = new ChapeauUserControl.Elements.Form.Input();
            this.btn_edit = new ChapeauUserControl.ButtonBase();
            this.role_txt = new System.Windows.Forms.ComboBox();
            this.textBody1 = new ChapeauUserControl.Elements.TextBody();
            this.textBody2 = new ChapeauUserControl.Elements.TextBody();
            this.textBody3 = new ChapeauUserControl.Elements.TextBody();
            this.textBody4 = new ChapeauUserControl.Elements.TextBody();
            this.btn_addEmployee = new ChapeauUserControl.ButtonBase();
            this.btn_refresh = new ChapeauUserControl.ButtonBase();
            this.navigation = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.btn_logout = new ChapeauUserControl.ButtonBase();
            this.navigationItem1 = new ChapeauUserControl.Layout.NavigationItem();
            this.navitem_employee = new ChapeauUserControl.Layout.NavigationItem();
            this.btn_close = new ChapeauUserControl.Elements.TextBody();
            this.lbl_menu = new ChapeauUserControl.Elements.TextBody();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listEmployees
            // 
            this.listEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.listEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEmployees.FullRowSelect = true;
            this.listEmployees.HideSelection = false;
            this.listEmployees.Location = new System.Drawing.Point(48, 249);
            this.listEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.listEmployees.Name = "listEmployees";
            this.listEmployees.Size = new System.Drawing.Size(468, 275);
            this.listEmployees.TabIndex = 0;
            this.listEmployees.UseCompatibleStateImageBehavior = false;
            this.listEmployees.View = System.Windows.Forms.View.Details;
            this.listEmployees.SelectedIndexChanged += new System.EventHandler(this.listEmployees_SelectedIndexChanged);
            // 
            // textHeading1
            // 
            this.textHeading1.AutoSize = true;
            this.textHeading1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.textHeading1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.textHeading1.Location = new System.Drawing.Point(43, 139);
            this.textHeading1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textHeading1.Name = "textHeading1";
            this.textHeading1.Size = new System.Drawing.Size(176, 29);
            this.textHeading1.TabIndex = 1;
            this.textHeading1.Text = "Employee List";
            // 
            // btn_deleteEmployee
            // 
            this.btn_deleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_deleteEmployee.FlatAppearance.BorderSize = 0;
            this.btn_deleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteEmployee.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_deleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_deleteEmployee.IsOutline = false;
            this.btn_deleteEmployee.Location = new System.Drawing.Point(594, 490);
            this.btn_deleteEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteEmployee.Name = "btn_deleteEmployee";
            this.btn_deleteEmployee.Size = new System.Drawing.Size(140, 35);
            this.btn_deleteEmployee.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_deleteEmployee.TabIndex = 2;
            this.btn_deleteEmployee.Text = "Delete Employee";
            this.btn_deleteEmployee.UseVisualStyleBackColor = true;
            this.btn_deleteEmployee.Click += new System.EventHandler(this.btn_deleteEmployee_Click);
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Arial", 12F);
            this.name_txt.Location = new System.Drawing.Point(594, 295);
            this.name_txt.Margin = new System.Windows.Forms.Padding(2);
            this.name_txt.Name = "name_txt";
            this.name_txt.PlaceholderText = null;
            this.name_txt.Size = new System.Drawing.Size(374, 26);
            this.name_txt.TabIndex = 3;
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Arial", 12F);
            this.password_txt.Location = new System.Drawing.Point(594, 365);
            this.password_txt.Margin = new System.Windows.Forms.Padding(2);
            this.password_txt.Name = "password_txt";
            this.password_txt.PlaceholderText = null;
            this.password_txt.Size = new System.Drawing.Size(374, 26);
            this.password_txt.TabIndex = 4;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.IsOutline = false;
            this.btn_edit.Location = new System.Drawing.Point(820, 490);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(148, 35);
            this.btn_edit.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit Employee";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // role_txt
            // 
            this.role_txt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_txt.FormattingEnabled = true;
            this.role_txt.Items.AddRange(new object[] {
            "Waiter",
            "Barman",
            "Chef",
            "Manager"});
            this.role_txt.Location = new System.Drawing.Point(594, 430);
            this.role_txt.Margin = new System.Windows.Forms.Padding(2);
            this.role_txt.Name = "role_txt";
            this.role_txt.Size = new System.Drawing.Size(374, 28);
            this.role_txt.TabIndex = 6;
            // 
            // textBody1
            // 
            this.textBody1.AutoSize = true;
            this.textBody1.Font = new System.Drawing.Font("Arial", 15F);
            this.textBody1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBody1.Location = new System.Drawing.Point(590, 261);
            this.textBody1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBody1.Name = "textBody1";
            this.textBody1.Size = new System.Drawing.Size(67, 23);
            this.textBody1.TabIndex = 7;
            this.textBody1.Text = "Name:";
            // 
            // textBody2
            // 
            this.textBody2.AutoSize = true;
            this.textBody2.Font = new System.Drawing.Font("Arial", 15F);
            this.textBody2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBody2.Location = new System.Drawing.Point(590, 340);
            this.textBody2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBody2.Name = "textBody2";
            this.textBody2.Size = new System.Drawing.Size(104, 23);
            this.textBody2.TabIndex = 8;
            this.textBody2.Text = "Password:";
            // 
            // textBody3
            // 
            this.textBody3.AutoSize = true;
            this.textBody3.Font = new System.Drawing.Font("Arial", 15F);
            this.textBody3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBody3.Location = new System.Drawing.Point(590, 405);
            this.textBody3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBody3.Name = "textBody3";
            this.textBody3.Size = new System.Drawing.Size(56, 23);
            this.textBody3.TabIndex = 9;
            this.textBody3.Text = "Role:";
            // 
            // textBody4
            // 
            this.textBody4.AutoSize = true;
            this.textBody4.Font = new System.Drawing.Font("Arial", 15F);
            this.textBody4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBody4.Location = new System.Drawing.Point(45, 210);
            this.textBody4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBody4.Name = "textBody4";
            this.textBody4.Size = new System.Drawing.Size(221, 23);
            this.textBody4.TabIndex = 10;
            this.textBody4.Text = "Click To View Employee";
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_addEmployee.FlatAppearance.BorderSize = 0;
            this.btn_addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addEmployee.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_addEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_addEmployee.IsOutline = false;
            this.btn_addEmployee.Location = new System.Drawing.Point(828, 139);
            this.btn_addEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(140, 35);
            this.btn_addEmployee.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_addEmployee.TabIndex = 11;
            this.btn_addEmployee.Text = "Add Employee";
            this.btn_addEmployee.UseVisualStyleBackColor = true;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_refresh.IsOutline = true;
            this.btn_refresh.Location = new System.Drawing.Point(828, 30);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(140, 35);
            this.btn_refresh.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_refresh.TabIndex = 12;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // navigation
            // 
            this.navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.navigation.Controls.Add(this.Logout);
            this.navigation.Controls.Add(this.btn_logout);
            this.navigation.Controls.Add(this.navigationItem1);
            this.navigation.Controls.Add(this.navitem_employee);
            this.navigation.Controls.Add(this.btn_close);
            this.navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigation.Location = new System.Drawing.Point(0, 0);
            this.navigation.Name = "navigation";
            this.navigation.Size = new System.Drawing.Size(225, 729);
            this.navigation.TabIndex = 13;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(12, 653);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(201, 53);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_logout.IsOutline = true;
            this.btn_logout.Location = new System.Drawing.Point(12, 757);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(201, 54);
            this.btn_logout.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // navigationItem1
            // 
            this.navigationItem1.BackColor = System.Drawing.Color.Transparent;
            this.navigationItem1.ItemActiveState = false;
            this.navigationItem1.Location = new System.Drawing.Point(0, 159);
            this.navigationItem1.Name = "navigationItem1";
            this.navigationItem1.NavigationText = "Menu";
            this.navigationItem1.Size = new System.Drawing.Size(224, 55);
            this.navigationItem1.TabIndex = 2;
            this.navigationItem1.Click += new System.EventHandler(this.navigationItem1_Click);
            // 
            // navitem_employee
            // 
            this.navitem_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.navitem_employee.ItemActiveState = true;
            this.navitem_employee.Location = new System.Drawing.Point(1, 101);
            this.navitem_employee.Name = "navitem_employee";
            this.navitem_employee.NavigationText = "Employee";
            this.navitem_employee.Size = new System.Drawing.Size(224, 55);
            this.navitem_employee.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.Font = new System.Drawing.Font("Arial", 13F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(25, 21);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(68, 21);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X close";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Arial", 13F);
            this.lbl_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.lbl_menu.Location = new System.Drawing.Point(25, 21);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(103, 21);
            this.lbl_menu.TabIndex = 14;
            this.lbl_menu.Text = "Open menu";
            this.lbl_menu.Click += new System.EventHandler(this.lbl_menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(458, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // Employee_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.navigation);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.role_txt);
            this.Controls.Add(this.btn_addEmployee);
            this.Controls.Add(this.textBody1);
            this.Controls.Add(this.textBody4);
            this.Controls.Add(this.textBody3);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.textBody2);
            this.Controls.Add(this.btn_deleteEmployee);
            this.Controls.Add(this.textHeading1);
            this.Controls.Add(this.listEmployees);
            this.Controls.Add(this.lbl_menu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employee_Edit";
            this.Text = "Employee_Edit";
            this.navigation.ResumeLayout(false);
            this.navigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listEmployees;
        private ChapeauUserControl.Elements.TextHeading textHeading1;
        private ChapeauUserControl.ButtonBase btn_deleteEmployee;
        private ChapeauUserControl.Elements.Form.Input name_txt;
        private ChapeauUserControl.Elements.Form.Input password_txt;
        private ChapeauUserControl.ButtonBase btn_edit;
        private System.Windows.Forms.ComboBox role_txt;
        private ChapeauUserControl.Elements.TextBody textBody1;
        private ChapeauUserControl.Elements.TextBody textBody2;
        private ChapeauUserControl.Elements.TextBody textBody3;
        private ChapeauUserControl.Elements.TextBody textBody4;
        private ChapeauUserControl.ButtonBase btn_addEmployee;
        private ChapeauUserControl.ButtonBase btn_refresh;
        private System.Windows.Forms.Panel navigation;
        private ChapeauUserControl.ButtonBase btn_logout;
        private ChapeauUserControl.Layout.NavigationItem navigationItem1;
        private ChapeauUserControl.Layout.NavigationItem navitem_employee;
        private ChapeauUserControl.Elements.TextBody btn_close;
        private System.Windows.Forms.Button Logout;
        private ChapeauUserControl.Elements.TextBody lbl_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}