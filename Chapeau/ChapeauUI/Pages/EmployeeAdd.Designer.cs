namespace ChapeauUI.Pages
{
    partial class EmployeeAdd
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
            this.btn_AddEmployee = new ChapeauUserControl.ButtonBase();
            this.AddName_txt = new ChapeauUserControl.Elements.Form.Input();
            this.textHeading1 = new ChapeauUserControl.Elements.TextHeading();
            this.textLabel2 = new ChapeauUserControl.Elements.TextLabel();
            this.lbl_name = new ChapeauUserControl.Elements.TextLabel();
            this.AddPassword_txt = new ChapeauUserControl.Elements.Form.Input();
            this.textLabel1 = new ChapeauUserControl.Elements.TextLabel();
            this.btn_EmployeeList = new ChapeauUserControl.ButtonBase();
            this.AddRole_txt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_AddEmployee
            // 
            this.btn_AddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_AddEmployee.FlatAppearance.BorderSize = 0;
            this.btn_AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddEmployee.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_AddEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_AddEmployee.IsOutline = false;
            this.btn_AddEmployee.Location = new System.Drawing.Point(321, 526);
            this.btn_AddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddEmployee.Name = "btn_AddEmployee";
            this.btn_AddEmployee.Size = new System.Drawing.Size(335, 48);
            this.btn_AddEmployee.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_AddEmployee.TabIndex = 15;
            this.btn_AddEmployee.Text = "Add New Employee";
            this.btn_AddEmployee.UseVisualStyleBackColor = true;
            this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
            // 
            // AddName_txt
            // 
            this.AddName_txt.Font = new System.Drawing.Font("Arial", 12F);
            this.AddName_txt.Location = new System.Drawing.Point(321, 270);
            this.AddName_txt.Margin = new System.Windows.Forms.Padding(2);
            this.AddName_txt.Name = "AddName_txt";
            this.AddName_txt.PlaceholderText = null;
            this.AddName_txt.Size = new System.Drawing.Size(335, 26);
            this.AddName_txt.TabIndex = 8;
            // 
            // textHeading1
            // 
            this.textHeading1.AutoSize = true;
            this.textHeading1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.textHeading1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.textHeading1.Location = new System.Drawing.Point(316, 117);
            this.textHeading1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textHeading1.Name = "textHeading1";
            this.textHeading1.Size = new System.Drawing.Size(218, 29);
            this.textHeading1.TabIndex = 11;
            this.textHeading1.Text = "Add An Employee";
            // 
            // textLabel2
            // 
            this.textLabel2.AutoSize = true;
            this.textLabel2.Font = new System.Drawing.Font("Arial", 12F);
            this.textLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textLabel2.Location = new System.Drawing.Point(318, 416);
            this.textLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textLabel2.Name = "textLabel2";
            this.textLabel2.Size = new System.Drawing.Size(44, 18);
            this.textLabel2.TabIndex = 14;
            this.textLabel2.Text = "Role:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_name.Location = new System.Drawing.Point(318, 235);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(54, 18);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Text = "Name:";
            // 
            // AddPassword_txt
            // 
            this.AddPassword_txt.Font = new System.Drawing.Font("Arial", 12F);
            this.AddPassword_txt.Location = new System.Drawing.Point(321, 355);
            this.AddPassword_txt.Margin = new System.Windows.Forms.Padding(2);
            this.AddPassword_txt.Name = "AddPassword_txt";
            this.AddPassword_txt.PlaceholderText = null;
            this.AddPassword_txt.Size = new System.Drawing.Size(335, 26);
            this.AddPassword_txt.TabIndex = 9;
            // 
            // textLabel1
            // 
            this.textLabel1.AutoSize = true;
            this.textLabel1.Font = new System.Drawing.Font("Arial", 12F);
            this.textLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textLabel1.Location = new System.Drawing.Point(318, 321);
            this.textLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textLabel1.Name = "textLabel1";
            this.textLabel1.Size = new System.Drawing.Size(82, 18);
            this.textLabel1.TabIndex = 13;
            this.textLabel1.Text = "Password:";
            // 
            // btn_EmployeeList
            // 
            this.btn_EmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_EmployeeList.FlatAppearance.BorderSize = 0;
            this.btn_EmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EmployeeList.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_EmployeeList.ForeColor = System.Drawing.Color.White;
            this.btn_EmployeeList.IsOutline = false;
            this.btn_EmployeeList.Location = new System.Drawing.Point(768, 639);
            this.btn_EmployeeList.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EmployeeList.Name = "btn_EmployeeList";
            this.btn_EmployeeList.Size = new System.Drawing.Size(197, 49);
            this.btn_EmployeeList.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_EmployeeList.TabIndex = 16;
            this.btn_EmployeeList.Text = "View Employee List";
            this.btn_EmployeeList.UseVisualStyleBackColor = true;
            this.btn_EmployeeList.Click += new System.EventHandler(this.btn_EmployeeList_Click);
            // 
            // AddRole_txt
            // 
            this.AddRole_txt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRole_txt.FormattingEnabled = true;
            this.AddRole_txt.Items.AddRange(new object[] {
            "Waiter",
            "Barman",
            "Chef",
            "Manager"});
            this.AddRole_txt.Location = new System.Drawing.Point(321, 446);
            this.AddRole_txt.Margin = new System.Windows.Forms.Padding(2);
            this.AddRole_txt.Name = "AddRole_txt";
            this.AddRole_txt.Size = new System.Drawing.Size(335, 28);
            this.AddRole_txt.TabIndex = 17;
            // 
            // EmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.AddRole_txt);
            this.Controls.Add(this.btn_EmployeeList);
            this.Controls.Add(this.btn_AddEmployee);
            this.Controls.Add(this.AddName_txt);
            this.Controls.Add(this.textHeading1);
            this.Controls.Add(this.textLabel2);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.AddPassword_txt);
            this.Controls.Add(this.textLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeAdd";
            this.Text = "EmployeeAdd";
            this.Load += new System.EventHandler(this.EmployeeAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChapeauUserControl.ButtonBase btn_AddEmployee;
        private ChapeauUserControl.Elements.Form.Input AddName_txt;
        private ChapeauUserControl.Elements.TextHeading textHeading1;
        private ChapeauUserControl.Elements.TextLabel textLabel2;
        private ChapeauUserControl.Elements.TextLabel lbl_name;
        private ChapeauUserControl.Elements.Form.Input AddPassword_txt;
        private ChapeauUserControl.Elements.TextLabel textLabel1;
        private ChapeauUserControl.ButtonBase btn_EmployeeList;
        private System.Windows.Forms.ComboBox AddRole_txt;
    }
}