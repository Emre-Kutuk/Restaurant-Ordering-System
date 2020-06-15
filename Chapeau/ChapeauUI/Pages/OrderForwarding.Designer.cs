namespace ChapeauUI.Pages
{
    partial class OrderForwarding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForwarding));
            this.pnl_kitchen = new System.Windows.Forms.Panel();
            this.btn_ready = new ChapeauUserControl.ButtonBase();
            this.btn_viewBar = new ChapeauUserControl.ButtonBase();
            this.listView_kitchenview = new System.Windows.Forms.ListView();
            this.textBody1 = new ChapeauUserControl.Elements.TextBody();
            this.textHeading1 = new ChapeauUserControl.Elements.TextHeading();
            this.pnl_bar = new System.Windows.Forms.Panel();
            this.btn_Drink_Ready = new ChapeauUserControl.ButtonBase();
            this.btn_Food = new ChapeauUserControl.ButtonBase();
            this.textBody2 = new ChapeauUserControl.Elements.TextBody();
            this.textHeading2 = new ChapeauUserControl.Elements.TextHeading();
            this.listView_Barview = new System.Windows.Forms.ListView();
            this.navigation = new System.Windows.Forms.Panel();
            this.navitem_dishes = new ChapeauUserControl.Layout.NavigationItem();
            this.btn_logout = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.navitem_drinks = new ChapeauUserControl.Layout.NavigationItem();
            this.btn_close = new ChapeauUserControl.Elements.TextBody();
            this.lbl_menu = new ChapeauUserControl.Elements.TextBody();
            this.Refreshview = new ChapeauUserControl.ButtonBase();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_kitchen.SuspendLayout();
            this.pnl_bar.SuspendLayout();
            this.navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_kitchen
            // 
            this.pnl_kitchen.Controls.Add(this.btn_ready);
            this.pnl_kitchen.Controls.Add(this.btn_viewBar);
            this.pnl_kitchen.Controls.Add(this.listView_kitchenview);
            this.pnl_kitchen.Controls.Add(this.textBody1);
            this.pnl_kitchen.Controls.Add(this.textHeading1);
            this.pnl_kitchen.Location = new System.Drawing.Point(22, 100);
            this.pnl_kitchen.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_kitchen.Name = "pnl_kitchen";
            this.pnl_kitchen.Size = new System.Drawing.Size(932, 703);
            this.pnl_kitchen.TabIndex = 0;
            // 
            // btn_ready
            // 
            this.btn_ready.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_ready.FlatAppearance.BorderSize = 0;
            this.btn_ready.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ready.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_ready.ForeColor = System.Drawing.Color.White;
            this.btn_ready.IsOutline = false;
            this.btn_ready.Location = new System.Drawing.Point(71, 482);
            this.btn_ready.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ready.Name = "btn_ready";
            this.btn_ready.Size = new System.Drawing.Size(260, 54);
            this.btn_ready.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_ready.TabIndex = 3;
            this.btn_ready.Text = "Mark as Ready";
            this.btn_ready.UseVisualStyleBackColor = true;
            this.btn_ready.Click += new System.EventHandler(this.btn_ready_Click);
            // 
            // btn_viewBar
            // 
            this.btn_viewBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_viewBar.FlatAppearance.BorderSize = 0;
            this.btn_viewBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewBar.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_viewBar.ForeColor = System.Drawing.Color.White;
            this.btn_viewBar.IsOutline = false;
            this.btn_viewBar.Location = new System.Drawing.Point(713, 15);
            this.btn_viewBar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_viewBar.Name = "btn_viewBar";
            this.btn_viewBar.Size = new System.Drawing.Size(135, 50);
            this.btn_viewBar.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_viewBar.TabIndex = 5;
            this.btn_viewBar.Text = "View Drinks";
            this.btn_viewBar.UseVisualStyleBackColor = true;
            this.btn_viewBar.Click += new System.EventHandler(this.btn_viewBar_Click);
            // 
            // listView_kitchenview
            // 
            this.listView_kitchenview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.listView_kitchenview.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_kitchenview.FullRowSelect = true;
            this.listView_kitchenview.HideSelection = false;
            this.listView_kitchenview.Location = new System.Drawing.Point(70, 115);
            this.listView_kitchenview.Margin = new System.Windows.Forms.Padding(2);
            this.listView_kitchenview.Name = "listView_kitchenview";
            this.listView_kitchenview.Size = new System.Drawing.Size(622, 340);
            this.listView_kitchenview.TabIndex = 2;
            this.listView_kitchenview.UseCompatibleStateImageBehavior = false;
            this.listView_kitchenview.View = System.Windows.Forms.View.Details;
            this.listView_kitchenview.SelectedIndexChanged += new System.EventHandler(this.listView_kitchenview_SelectedIndexChanged);
            // 
            // textBody1
            // 
            this.textBody1.AutoSize = true;
            this.textBody1.Font = new System.Drawing.Font("Arial", 15F);
            this.textBody1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.textBody1.Location = new System.Drawing.Point(67, 61);
            this.textBody1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBody1.Name = "textBody1";
            this.textBody1.Size = new System.Drawing.Size(194, 23);
            this.textBody1.TabIndex = 1;
            this.textBody1.Text = "Click to Select Order";
            // 
            // textHeading1
            // 
            this.textHeading1.AutoSize = true;
            this.textHeading1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.textHeading1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.textHeading1.Location = new System.Drawing.Point(66, 24);
            this.textHeading1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textHeading1.Name = "textHeading1";
            this.textHeading1.Size = new System.Drawing.Size(185, 29);
            this.textHeading1.TabIndex = 0;
            this.textHeading1.Text = "Kitchen Orders";
            // 
            // pnl_bar
            // 
            this.pnl_bar.Controls.Add(this.btn_Drink_Ready);
            this.pnl_bar.Controls.Add(this.btn_Food);
            this.pnl_bar.Controls.Add(this.textBody2);
            this.pnl_bar.Controls.Add(this.textHeading2);
            this.pnl_bar.Controls.Add(this.listView_Barview);
            this.pnl_bar.Location = new System.Drawing.Point(22, 100);
            this.pnl_bar.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_bar.Name = "pnl_bar";
            this.pnl_bar.Size = new System.Drawing.Size(944, 631);
            this.pnl_bar.TabIndex = 4;
            // 
            // btn_Drink_Ready
            // 
            this.btn_Drink_Ready.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Drink_Ready.FlatAppearance.BorderSize = 0;
            this.btn_Drink_Ready.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Drink_Ready.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_Drink_Ready.ForeColor = System.Drawing.Color.White;
            this.btn_Drink_Ready.IsOutline = false;
            this.btn_Drink_Ready.Location = new System.Drawing.Point(71, 482);
            this.btn_Drink_Ready.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Drink_Ready.Name = "btn_Drink_Ready";
            this.btn_Drink_Ready.Size = new System.Drawing.Size(260, 54);
            this.btn_Drink_Ready.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_Drink_Ready.TabIndex = 9;
            this.btn_Drink_Ready.Text = "Mark as Ready";
            this.btn_Drink_Ready.UseVisualStyleBackColor = true;
            this.btn_Drink_Ready.Click += new System.EventHandler(this.btn_Drink_Ready_Click);
            // 
            // btn_Food
            // 
            this.btn_Food.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Food.FlatAppearance.BorderSize = 0;
            this.btn_Food.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Food.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_Food.ForeColor = System.Drawing.Color.White;
            this.btn_Food.IsOutline = false;
            this.btn_Food.Location = new System.Drawing.Point(713, 15);
            this.btn_Food.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Food.Name = "btn_Food";
            this.btn_Food.Size = new System.Drawing.Size(135, 50);
            this.btn_Food.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_Food.TabIndex = 8;
            this.btn_Food.Text = "View Food";
            this.btn_Food.UseVisualStyleBackColor = true;
            this.btn_Food.Click += new System.EventHandler(this.btn_Food_Click);
            // 
            // textBody2
            // 
            this.textBody2.AutoSize = true;
            this.textBody2.Font = new System.Drawing.Font("Arial", 15F);
            this.textBody2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.textBody2.Location = new System.Drawing.Point(65, 52);
            this.textBody2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBody2.Name = "textBody2";
            this.textBody2.Size = new System.Drawing.Size(194, 23);
            this.textBody2.TabIndex = 7;
            this.textBody2.Text = "Click to Select Order";
            // 
            // textHeading2
            // 
            this.textHeading2.AutoSize = true;
            this.textHeading2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.textHeading2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.textHeading2.Location = new System.Drawing.Point(64, 15);
            this.textHeading2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textHeading2.Name = "textHeading2";
            this.textHeading2.Size = new System.Drawing.Size(136, 29);
            this.textHeading2.TabIndex = 6;
            this.textHeading2.Text = "Bar Orders";
            // 
            // listView_Barview
            // 
            this.listView_Barview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.listView_Barview.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Barview.FullRowSelect = true;
            this.listView_Barview.HideSelection = false;
            this.listView_Barview.Location = new System.Drawing.Point(71, 88);
            this.listView_Barview.Margin = new System.Windows.Forms.Padding(2);
            this.listView_Barview.Name = "listView_Barview";
            this.listView_Barview.Size = new System.Drawing.Size(609, 381);
            this.listView_Barview.TabIndex = 0;
            this.listView_Barview.UseCompatibleStateImageBehavior = false;
            this.listView_Barview.View = System.Windows.Forms.View.Details;
            this.listView_Barview.SelectedIndexChanged += new System.EventHandler(this.listView_Barview_SelectedIndexChanged);
            // 
            // navigation
            // 
            this.navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.navigation.Controls.Add(this.navitem_dishes);
            this.navigation.Controls.Add(this.btn_logout);
            this.navigation.Controls.Add(this.Logout);
            this.navigation.Controls.Add(this.navitem_drinks);
            this.navigation.Controls.Add(this.btn_close);
            this.navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigation.Location = new System.Drawing.Point(0, 0);
            this.navigation.Name = "navigation";
            this.navigation.Size = new System.Drawing.Size(225, 729);
            this.navigation.TabIndex = 7;
            // 
            // navitem_dishes
            // 
            this.navitem_dishes.BackColor = System.Drawing.Color.Transparent;
            this.navitem_dishes.ItemActiveState = false;
            this.navitem_dishes.Location = new System.Drawing.Point(1, 160);
            this.navitem_dishes.Name = "navitem_dishes";
            this.navitem_dishes.NavigationText = "Kitchen orders";
            this.navitem_dishes.Size = new System.Drawing.Size(224, 55);
            this.navitem_dishes.TabIndex = 6;
            this.navitem_dishes.Click += new System.EventHandler(this.navitem_dishes_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(12, 651);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(201, 53);
            this.btn_logout.TabIndex = 5;
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
            // 
            // navitem_drinks
            // 
            this.navitem_drinks.BackColor = System.Drawing.Color.Transparent;
            this.navitem_drinks.ItemActiveState = false;
            this.navitem_drinks.Location = new System.Drawing.Point(1, 101);
            this.navitem_drinks.Name = "navitem_drinks";
            this.navitem_drinks.NavigationText = "Bar orders";
            this.navitem_drinks.Size = new System.Drawing.Size(224, 55);
            this.navitem_drinks.TabIndex = 1;
            this.navitem_drinks.Click += new System.EventHandler(this.navitem_drinks_Click);
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
            this.lbl_menu.TabIndex = 17;
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
            this.Refreshview.TabIndex = 26;
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
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // OrderForwarding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Refreshview);
            this.Controls.Add(this.navigation);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.pnl_bar);
            this.Controls.Add(this.pnl_kitchen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderForwarding";
            this.Text = "Order Forwarding";
            this.pnl_kitchen.ResumeLayout(false);
            this.pnl_kitchen.PerformLayout();
            this.pnl_bar.ResumeLayout(false);
            this.pnl_bar.PerformLayout();
            this.navigation.ResumeLayout(false);
            this.navigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_kitchen;
        private ChapeauUserControl.Elements.TextHeading textHeading1;
        private System.Windows.Forms.ListView listView_kitchenview;
        private ChapeauUserControl.Elements.TextBody textBody1;
        private ChapeauUserControl.ButtonBase btn_ready;
        private System.Windows.Forms.Panel pnl_bar;
        private System.Windows.Forms.ListView listView_Barview;
        private ChapeauUserControl.ButtonBase btn_viewBar;
        private ChapeauUserControl.ButtonBase btn_Food;
        private ChapeauUserControl.Elements.TextBody textBody2;
        private ChapeauUserControl.Elements.TextHeading textHeading2;
        private ChapeauUserControl.ButtonBase btn_Drink_Ready;
        private System.Windows.Forms.Panel navigation;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button Logout;
        private ChapeauUserControl.Layout.NavigationItem navitem_drinks;
        private ChapeauUserControl.Elements.TextBody btn_close;
        private ChapeauUserControl.Elements.TextBody lbl_menu;
        private ChapeauUserControl.Layout.NavigationItem navitem_dishes;
        private ChapeauUserControl.ButtonBase Refreshview;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}