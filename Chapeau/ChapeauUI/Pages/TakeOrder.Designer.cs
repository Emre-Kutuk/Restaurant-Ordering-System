namespace ChapeauUI.Pages
{
    partial class TakeOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeOrder));
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelMenuCategorie = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelMenuItem = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelOrderedItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_price = new ChapeauUserControl.Elements.TextLabel();
            this.lbl_stock = new ChapeauUserControl.Elements.TextLabel();
            this.lbl_item_name = new ChapeauUserControl.Elements.TextLabel();
            this.btn_remove_all = new ChapeauUserControl.ButtonBase();
            this.btn_showOrder = new ChapeauUserControl.ButtonBase();
            this.btn_order = new ChapeauUserControl.ButtonBase();
            this.input_comment = new ChapeauUserControl.Elements.Form.Input();
            this.quantityInput = new ChapeauUserControl.Elements.Form.QuantityInput();
            this.lbl_ActiveMenu = new ChapeauUserControl.Elements.TextBody();
            this.btn_back = new ChapeauUserControl.ButtonBase();
            this.lbl_tableNumber = new ChapeauUserControl.Elements.TextHeading();
            this.textHeading = new ChapeauUserControl.Elements.TextHeading();
            this.btn_refresh = new ChapeauUserControl.ButtonBase();
            this.navigation = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.navitem_overview = new ChapeauUserControl.Layout.NavigationItem();
            this.btn_close = new ChapeauUserControl.Elements.TextBody();
            this.lbl_menu = new ChapeauUserControl.Elements.TextBody();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(21, 182);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(220, 345);
            this.flowLayoutPanelMenu.TabIndex = 2;
            // 
            // flowLayoutPanelMenuCategorie
            // 
            this.flowLayoutPanelMenuCategorie.Location = new System.Drawing.Point(21, 181);
            this.flowLayoutPanelMenuCategorie.Name = "flowLayoutPanelMenuCategorie";
            this.flowLayoutPanelMenuCategorie.Size = new System.Drawing.Size(220, 438);
            this.flowLayoutPanelMenuCategorie.TabIndex = 3;
            // 
            // flowLayoutPanelMenuItem
            // 
            this.flowLayoutPanelMenuItem.AutoScroll = true;
            this.flowLayoutPanelMenuItem.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelMenuItem.Location = new System.Drawing.Point(247, 182);
            this.flowLayoutPanelMenuItem.Name = "flowLayoutPanelMenuItem";
            this.flowLayoutPanelMenuItem.Size = new System.Drawing.Size(740, 370);
            this.flowLayoutPanelMenuItem.TabIndex = 4;
            // 
            // flowLayoutPanelOrderedItems
            // 
            this.flowLayoutPanelOrderedItems.AutoScroll = true;
            this.flowLayoutPanelOrderedItems.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelOrderedItems.Location = new System.Drawing.Point(247, 182);
            this.flowLayoutPanelOrderedItems.Name = "flowLayoutPanelOrderedItems";
            this.flowLayoutPanelOrderedItems.Size = new System.Drawing.Size(740, 370);
            this.flowLayoutPanelOrderedItems.TabIndex = 5;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.lbl_price.Location = new System.Drawing.Point(815, 157);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(43, 18);
            this.lbl_price.TabIndex = 15;
            this.lbl_price.Text = "price";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.lbl_stock.Location = new System.Drawing.Point(598, 157);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(45, 18);
            this.lbl_stock.TabIndex = 14;
            this.lbl_stock.Text = "stock";
            // 
            // lbl_item_name
            // 
            this.lbl_item_name.AutoSize = true;
            this.lbl_item_name.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_item_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.lbl_item_name.Location = new System.Drawing.Point(283, 157);
            this.lbl_item_name.Name = "lbl_item_name";
            this.lbl_item_name.Size = new System.Drawing.Size(80, 18);
            this.lbl_item_name.TabIndex = 13;
            this.lbl_item_name.Text = "menu item";
            // 
            // btn_remove_all
            // 
            this.btn_remove_all.BackColor = System.Drawing.Color.Transparent;
            this.btn_remove_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_all.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_remove_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_remove_all.IsOutline = true;
            this.btn_remove_all.Location = new System.Drawing.Point(641, 89);
            this.btn_remove_all.Name = "btn_remove_all";
            this.btn_remove_all.Size = new System.Drawing.Size(170, 50);
            this.btn_remove_all.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_remove_all.TabIndex = 11;
            this.btn_remove_all.Text = "Remove all items";
            this.btn_remove_all.UseVisualStyleBackColor = false;
            this.btn_remove_all.Click += new System.EventHandler(this.btn_remove_all_Click);
            // 
            // btn_showOrder
            // 
            this.btn_showOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_showOrder.FlatAppearance.BorderSize = 0;
            this.btn_showOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showOrder.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_showOrder.ForeColor = System.Drawing.Color.White;
            this.btn_showOrder.IsOutline = false;
            this.btn_showOrder.Location = new System.Drawing.Point(817, 89);
            this.btn_showOrder.Name = "btn_showOrder";
            this.btn_showOrder.Size = new System.Drawing.Size(170, 50);
            this.btn_showOrder.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_showOrder.TabIndex = 10;
            this.btn_showOrder.Text = "Show ordered items";
            this.btn_showOrder.UseVisualStyleBackColor = true;
            this.btn_showOrder.Click += new System.EventHandler(this.btn_showOrder_Click);
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_order.FlatAppearance.BorderSize = 0;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_order.ForeColor = System.Drawing.Color.White;
            this.btn_order.IsOutline = false;
            this.btn_order.Location = new System.Drawing.Point(770, 656);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(215, 50);
            this.btn_order.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_order.TabIndex = 9;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // input_comment
            // 
            this.input_comment.Font = new System.Drawing.Font("Arial", 12F);
            this.input_comment.Location = new System.Drawing.Point(286, 587);
            this.input_comment.Name = "input_comment";
            this.input_comment.PlaceholderText = "Comment...";
            this.input_comment.Size = new System.Drawing.Size(286, 26);
            this.input_comment.TabIndex = 8;
            this.input_comment.Text = "Comment...";
            this.input_comment.Leave += new System.EventHandler(this.input_comment_Leave);
            // 
            // quantityInput
            // 
            this.quantityInput.BackColor = System.Drawing.Color.White;
            this.quantityInput.CurrentValue = 0;
            this.quantityInput.Location = new System.Drawing.Point(838, 572);
            this.quantityInput.MaxValue = 10;
            this.quantityInput.MinValue = 0;
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(150, 50);
            this.quantityInput.TabIndex = 7;
            // 
            // lbl_ActiveMenu
            // 
            this.lbl_ActiveMenu.AutoSize = true;
            this.lbl_ActiveMenu.Font = new System.Drawing.Font("Arial", 15F);
            this.lbl_ActiveMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.lbl_ActiveMenu.Location = new System.Drawing.Point(20, 152);
            this.lbl_ActiveMenu.Name = "lbl_ActiveMenu";
            this.lbl_ActiveMenu.Size = new System.Drawing.Size(58, 23);
            this.lbl_ActiveMenu.TabIndex = 6;
            this.lbl_ActiveMenu.Text = "Menu";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_back.IsOutline = true;
            this.btn_back.Location = new System.Drawing.Point(21, 656);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(220, 52);
            this.btn_back.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_tableNumber
            // 
            this.lbl_tableNumber.AutoSize = true;
            this.lbl_tableNumber.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_tableNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.lbl_tableNumber.Location = new System.Drawing.Point(218, 97);
            this.lbl_tableNumber.Name = "lbl_tableNumber";
            this.lbl_tableNumber.Size = new System.Drawing.Size(29, 29);
            this.lbl_tableNumber.TabIndex = 1;
            this.lbl_tableNumber.Text = "X";
            // 
            // textHeading
            // 
            this.textHeading.AutoSize = true;
            this.textHeading.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.textHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.textHeading.Location = new System.Drawing.Point(19, 97);
            this.textHeading.Name = "textHeading";
            this.textHeading.Size = new System.Drawing.Size(205, 29);
            this.textHeading.TabIndex = 0;
            this.textHeading.Text = "New order: Table";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_refresh.IsOutline = true;
            this.btn_refresh.Location = new System.Drawing.Point(815, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(170, 50);
            this.btn_refresh.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // navigation
            // 
            this.navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.navigation.Controls.Add(this.btn_logout);
            this.navigation.Controls.Add(this.Logout);
            this.navigation.Controls.Add(this.navitem_overview);
            this.navigation.Controls.Add(this.btn_close);
            this.navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigation.Location = new System.Drawing.Point(0, 0);
            this.navigation.Name = "navigation";
            this.navigation.Size = new System.Drawing.Size(225, 729);
            this.navigation.TabIndex = 47;
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
            // navitem_overview
            // 
            this.navitem_overview.BackColor = System.Drawing.Color.Transparent;
            this.navitem_overview.ItemActiveState = false;
            this.navitem_overview.Location = new System.Drawing.Point(1, 101);
            this.navitem_overview.Name = "navitem_overview";
            this.navitem_overview.NavigationText = "Overview";
            this.navitem_overview.Size = new System.Drawing.Size(224, 55);
            this.navitem_overview.TabIndex = 1;
            this.navitem_overview.Click += new System.EventHandler(this.navitem_overview_Click);
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
            this.lbl_menu.TabIndex = 48;
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
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // TakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.navigation);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.lbl_item_name);
            this.Controls.Add(this.btn_remove_all);
            this.Controls.Add(this.btn_showOrder);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.input_comment);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.lbl_ActiveMenu);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.flowLayoutPanelMenuCategorie);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.Controls.Add(this.lbl_tableNumber);
            this.Controls.Add(this.textHeading);
            this.Controls.Add(this.flowLayoutPanelOrderedItems);
            this.Controls.Add(this.flowLayoutPanelMenuItem);
            this.Name = "TakeOrder";
            this.navigation.ResumeLayout(false);
            this.navigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChapeauUserControl.Elements.TextHeading textHeading;
        private ChapeauUserControl.Elements.TextHeading lbl_tableNumber;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuCategorie;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuItem;
        private ChapeauUserControl.ButtonBase btn_back;
        private ChapeauUserControl.Elements.TextBody lbl_ActiveMenu;
        private ChapeauUserControl.Elements.Form.QuantityInput quantityInput;
        private ChapeauUserControl.Elements.Form.Input input_comment;
        private ChapeauUserControl.ButtonBase btn_order;
        private ChapeauUserControl.ButtonBase btn_showOrder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrderedItems;
        private ChapeauUserControl.ButtonBase btn_remove_all;
        private ChapeauUserControl.Elements.TextLabel lbl_item_name;
        private ChapeauUserControl.Elements.TextLabel lbl_stock;
        private ChapeauUserControl.Elements.TextLabel lbl_price;
        private ChapeauUserControl.ButtonBase btn_refresh;
        private System.Windows.Forms.Panel navigation;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button Logout;
        private ChapeauUserControl.Layout.NavigationItem navitem_overview;
        private ChapeauUserControl.Elements.TextBody btn_close;
        private ChapeauUserControl.Elements.TextBody lbl_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
