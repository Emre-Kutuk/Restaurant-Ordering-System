namespace ChapeauUI.Pages
{
    partial class MenuEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEdit));
            this.pnl_menu_edit = new System.Windows.Forms.Panel();
            this.btn_editStock = new ChapeauUserControl.ButtonBase();
            this.textBody6 = new ChapeauUserControl.Elements.TextBody();
            this.textBody4 = new ChapeauUserControl.Elements.TextBody();
            this.stock_txt = new ChapeauUserControl.Elements.Form.Input();
            this.textBody5 = new ChapeauUserControl.Elements.TextBody();
            this.lbl_itemName = new ChapeauUserControl.Elements.TextLabel();
            this.textHeading1 = new ChapeauUserControl.Elements.TextHeading();
            this.listView_menu_edit = new System.Windows.Forms.ListView();
            this.navigation = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.navigationItem1 = new ChapeauUserControl.Layout.NavigationItem();
            this.navitem_employee = new ChapeauUserControl.Layout.NavigationItem();
            this.btn_close = new ChapeauUserControl.Elements.TextBody();
            this.lbl_menu = new ChapeauUserControl.Elements.TextBody();
            this.Refreshview = new ChapeauUserControl.ButtonBase();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_menu_edit.SuspendLayout();
            this.navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu_edit
            // 
            this.pnl_menu_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.pnl_menu_edit.Controls.Add(this.btn_editStock);
            this.pnl_menu_edit.Controls.Add(this.textBody6);
            this.pnl_menu_edit.Controls.Add(this.textBody4);
            this.pnl_menu_edit.Controls.Add(this.stock_txt);
            this.pnl_menu_edit.Controls.Add(this.textBody5);
            this.pnl_menu_edit.Controls.Add(this.lbl_itemName);
            this.pnl_menu_edit.Controls.Add(this.textHeading1);
            this.pnl_menu_edit.Controls.Add(this.listView_menu_edit);
            this.pnl_menu_edit.Location = new System.Drawing.Point(56, 87);
            this.pnl_menu_edit.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_menu_edit.Name = "pnl_menu_edit";
            this.pnl_menu_edit.Size = new System.Drawing.Size(948, 543);
            this.pnl_menu_edit.TabIndex = 0;
            // 
            // btn_editStock
            // 
            this.btn_editStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_editStock.FlatAppearance.BorderSize = 0;
            this.btn_editStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editStock.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_editStock.ForeColor = System.Drawing.Color.White;
            this.btn_editStock.IsOutline = false;
            this.btn_editStock.Location = new System.Drawing.Point(605, 330);
            this.btn_editStock.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editStock.Name = "btn_editStock";
            this.btn_editStock.Size = new System.Drawing.Size(189, 49);
            this.btn_editStock.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_editStock.TabIndex = 5;
            this.btn_editStock.Text = "Change Stock";
            this.btn_editStock.UseVisualStyleBackColor = true;
            this.btn_editStock.Click += new System.EventHandler(this.btn_editStock_Click);
            // 
            // textBody6
            // 
            this.textBody6.AutoSize = true;
            this.textBody6.Font = new System.Drawing.Font("Arial", 15F);
            this.textBody6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBody6.Location = new System.Drawing.Point(601, 253);
            this.textBody6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBody6.Name = "textBody6";
            this.textBody6.Size = new System.Drawing.Size(66, 23);
            this.textBody6.TabIndex = 4;
            this.textBody6.Text = "Stock:";
            // 
            // textBody4
            // 
            this.textBody4.AutoSize = true;
            this.textBody4.Font = new System.Drawing.Font("Arial", 15F);
            this.textBody4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBody4.Location = new System.Drawing.Point(28, 66);
            this.textBody4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBody4.Name = "textBody4";
            this.textBody4.Size = new System.Drawing.Size(185, 23);
            this.textBody4.TabIndex = 4;
            this.textBody4.Text = "Click To Select Item";
            // 
            // stock_txt
            // 
            this.stock_txt.Font = new System.Drawing.Font("Arial", 12F);
            this.stock_txt.Location = new System.Drawing.Point(692, 253);
            this.stock_txt.Margin = new System.Windows.Forms.Padding(2);
            this.stock_txt.Name = "stock_txt";
            this.stock_txt.PlaceholderText = null;
            this.stock_txt.Size = new System.Drawing.Size(102, 26);
            this.stock_txt.TabIndex = 3;
            // 
            // textBody5
            // 
            this.textBody5.AutoSize = true;
            this.textBody5.Font = new System.Drawing.Font("Arial", 15F);
            this.textBody5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBody5.Location = new System.Drawing.Point(601, 204);
            this.textBody5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBody5.Name = "textBody5";
            this.textBody5.Size = new System.Drawing.Size(112, 23);
            this.textBody5.TabIndex = 2;
            this.textBody5.Text = "Item Name:";
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.AutoSize = true;
            this.lbl_itemName.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_itemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_itemName.Location = new System.Drawing.Point(724, 204);
            this.lbl_itemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(0, 18);
            this.lbl_itemName.TabIndex = 1;
            // 
            // textHeading1
            // 
            this.textHeading1.AutoSize = true;
            this.textHeading1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.textHeading1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.textHeading1.Location = new System.Drawing.Point(27, 14);
            this.textHeading1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textHeading1.Name = "textHeading1";
            this.textHeading1.Size = new System.Drawing.Size(130, 29);
            this.textHeading1.TabIndex = 1;
            this.textHeading1.Text = "Edit Menu";
            // 
            // listView_menu_edit
            // 
            this.listView_menu_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.listView_menu_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_menu_edit.FullRowSelect = true;
            this.listView_menu_edit.HideSelection = false;
            this.listView_menu_edit.Location = new System.Drawing.Point(32, 117);
            this.listView_menu_edit.Margin = new System.Windows.Forms.Padding(2);
            this.listView_menu_edit.Name = "listView_menu_edit";
            this.listView_menu_edit.Size = new System.Drawing.Size(536, 383);
            this.listView_menu_edit.TabIndex = 0;
            this.listView_menu_edit.UseCompatibleStateImageBehavior = false;
            this.listView_menu_edit.View = System.Windows.Forms.View.Details;
            this.listView_menu_edit.SelectedIndexChanged += new System.EventHandler(this.listView_menu_edit_SelectedIndexChanged);
            // 
            // navigation
            // 
            this.navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.navigation.Controls.Add(this.btn_logout);
            this.navigation.Controls.Add(this.Logout);
            this.navigation.Controls.Add(this.navigationItem1);
            this.navigation.Controls.Add(this.navitem_employee);
            this.navigation.Controls.Add(this.btn_close);
            this.navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigation.Location = new System.Drawing.Point(0, 0);
            this.navigation.Name = "navigation";
            this.navigation.Size = new System.Drawing.Size(225, 729);
            this.navigation.TabIndex = 1;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(12, 652);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(201, 53);
            this.btn_logout.TabIndex = 16;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(12, 755);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(201, 53);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // navigationItem1
            // 
            this.navigationItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.navigationItem1.ItemActiveState = true;
            this.navigationItem1.Location = new System.Drawing.Point(0, 162);
            this.navigationItem1.Name = "navigationItem1";
            this.navigationItem1.NavigationText = "Menu";
            this.navigationItem1.Size = new System.Drawing.Size(224, 55);
            this.navigationItem1.TabIndex = 2;
            // 
            // navitem_employee
            // 
            this.navitem_employee.BackColor = System.Drawing.Color.Transparent;
            this.navitem_employee.ItemActiveState = false;
            this.navitem_employee.Location = new System.Drawing.Point(1, 101);
            this.navitem_employee.Name = "navitem_employee";
            this.navitem_employee.NavigationText = "Employee";
            this.navitem_employee.Size = new System.Drawing.Size(224, 55);
            this.navitem_employee.TabIndex = 1;
            this.navitem_employee.Click += new System.EventHandler(this.navitem_employee_Click);
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
            this.lbl_menu.TabIndex = 15;
            this.lbl_menu.Text = "Open menu";
            this.lbl_menu.Click += new System.EventHandler(this.lbl_menu_Click);
            // 
            // Refreshview
            // 
            this.Refreshview.BackColor = System.Drawing.Color.Transparent;
            this.Refreshview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refreshview.Font = new System.Drawing.Font("Arial", 12F);
            this.Refreshview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.Refreshview.IsOutline = true;
            this.Refreshview.Location = new System.Drawing.Point(877, 21);
            this.Refreshview.Margin = new System.Windows.Forms.Padding(2);
            this.Refreshview.Name = "Refreshview";
            this.Refreshview.Size = new System.Drawing.Size(102, 37);
            this.Refreshview.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.Refreshview.TabIndex = 27;
            this.Refreshview.Text = "Refresh";
            this.Refreshview.UseVisualStyleBackColor = false;
            this.Refreshview.Click += new System.EventHandler(this.Refreshview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(458, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // MenuEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Refreshview);
            this.Controls.Add(this.navigation);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.pnl_menu_edit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuEdit";
            this.Text = "MenuEdit";
            this.pnl_menu_edit.ResumeLayout(false);
            this.pnl_menu_edit.PerformLayout();
            this.navigation.ResumeLayout(false);
            this.navigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu_edit;
        private System.Windows.Forms.ListView listView_menu_edit;
        private ChapeauUserControl.Elements.TextHeading textHeading1;
        private ChapeauUserControl.Elements.TextBody textBody4;
        private ChapeauUserControl.ButtonBase btn_editStock;
        private ChapeauUserControl.Elements.TextBody textBody6;
        private ChapeauUserControl.Elements.Form.Input stock_txt;
        private ChapeauUserControl.Elements.TextBody textBody5;
        private ChapeauUserControl.Elements.TextLabel lbl_itemName;
        private System.Windows.Forms.Panel navigation;
        private ChapeauUserControl.Elements.TextBody btn_close;
        private ChapeauUserControl.Layout.NavigationItem navitem_employee;
        private ChapeauUserControl.Layout.NavigationItem navigationItem1;
        private System.Windows.Forms.Button Logout;
        private ChapeauUserControl.Elements.TextBody lbl_menu;
        private System.Windows.Forms.Button btn_logout;
        private ChapeauUserControl.ButtonBase Refreshview;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}