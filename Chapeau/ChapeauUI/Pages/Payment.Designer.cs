namespace ChapeauUI.Pages
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.listPayment = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new ChapeauUserControl.ButtonBase();
            this.lblTotalWithVat = new ChapeauUserControl.Elements.TextLabel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnCheckOut = new ChapeauUserControl.ButtonBase();
            this.txtBoxTip = new System.Windows.Forms.TextBox();
            this.lblVAT = new ChapeauUserControl.Elements.TextLabel();
            this.lblPrice = new ChapeauUserControl.Elements.TextLabel();
            this.txtBoxComment = new System.Windows.Forms.RichTextBox();
            this.textLabel5 = new ChapeauUserControl.Elements.TextLabel();
            this.textLabel4 = new ChapeauUserControl.Elements.TextLabel();
            this.textLabel3 = new ChapeauUserControl.Elements.TextLabel();
            this.textLabel2 = new ChapeauUserControl.Elements.TextLabel();
            this.textLabel1 = new ChapeauUserControl.Elements.TextLabel();
            this.lblPayment = new ChapeauUserControl.Elements.TextBody();
            this.textBody1 = new ChapeauUserControl.Elements.TextBody();
            this.textHeading1 = new ChapeauUserControl.Elements.TextHeading();
            this.navigation = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.navitem_overview = new ChapeauUserControl.Layout.NavigationItem();
            this.btn_close = new ChapeauUserControl.Elements.TextBody();
            this.lbl_menu = new ChapeauUserControl.Elements.TextBody();
            this.Refreshview = new ChapeauUserControl.ButtonBase();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listPayment
            // 
            this.listPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.listPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPayment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPayment.FullRowSelect = true;
            this.listPayment.HideSelection = false;
            this.listPayment.Location = new System.Drawing.Point(30, 240);
            this.listPayment.Name = "listPayment";
            this.listPayment.Size = new System.Drawing.Size(415, 205);
            this.listPayment.TabIndex = 0;
            this.listPayment.UseCompatibleStateImageBehavior = false;
            this.listPayment.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.lblTotalWithVat);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.txtBoxTip);
            this.panel1.Controls.Add(this.lblVAT);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.txtBoxComment);
            this.panel1.Controls.Add(this.textLabel5);
            this.panel1.Controls.Add(this.textLabel4);
            this.panel1.Controls.Add(this.textLabel3);
            this.panel1.Controls.Add(this.textLabel2);
            this.panel1.Controls.Add(this.textLabel1);
            this.panel1.Controls.Add(this.lblPayment);
            this.panel1.Location = new System.Drawing.Point(643, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 731);
            this.panel1.TabIndex = 5;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_cancel.IsOutline = true;
            this.btn_cancel.Location = new System.Drawing.Point(34, 656);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(302, 43);
            this.btn_cancel.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lblTotalWithVat
            // 
            this.lblTotalWithVat.AutoSize = true;
            this.lblTotalWithVat.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalWithVat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.lblTotalWithVat.Location = new System.Drawing.Point(256, 272);
            this.lblTotalWithVat.MaximumSize = new System.Drawing.Size(80, 0);
            this.lblTotalWithVat.MinimumSize = new System.Drawing.Size(80, 0);
            this.lblTotalWithVat.Name = "lblTotalWithVat";
            this.lblTotalWithVat.Size = new System.Drawing.Size(80, 21);
            this.lblTotalWithVat.TabIndex = 18;
            this.lblTotalWithVat.Text = "€";
            this.lblTotalWithVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(34, 561);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 24);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Cash";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(34, 538);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 24);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.Text = "Pin";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(34, 515);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(173, 24);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.Text = "Credit Card(VISA/AMEX)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.IsOutline = false;
            this.btnCheckOut.Location = new System.Drawing.Point(34, 607);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(302, 43);
            this.btnCheckOut.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btnCheckOut.TabIndex = 14;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtBoxTip
            // 
            this.txtBoxTip.Location = new System.Drawing.Point(285, 202);
            this.txtBoxTip.Name = "txtBoxTip";
            this.txtBoxTip.Size = new System.Drawing.Size(51, 20);
            this.txtBoxTip.TabIndex = 13;
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVAT.Location = new System.Drawing.Point(256, 175);
            this.lblVAT.MaximumSize = new System.Drawing.Size(80, 0);
            this.lblVAT.MinimumSize = new System.Drawing.Size(80, 0);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(80, 19);
            this.lblVAT.TabIndex = 12;
            this.lblVAT.Text = "€";
            this.lblVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(256, 150);
            this.lblPrice.MaximumSize = new System.Drawing.Size(80, 0);
            this.lblPrice.MinimumSize = new System.Drawing.Size(80, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(80, 19);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "€";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxComment
            // 
            this.txtBoxComment.Location = new System.Drawing.Point(34, 351);
            this.txtBoxComment.Name = "txtBoxComment";
            this.txtBoxComment.Size = new System.Drawing.Size(302, 133);
            this.txtBoxComment.TabIndex = 10;
            this.txtBoxComment.Text = "";
            // 
            // textLabel5
            // 
            this.textLabel5.AutoSize = true;
            this.textLabel5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textLabel5.Location = new System.Drawing.Point(31, 320);
            this.textLabel5.Name = "textLabel5";
            this.textLabel5.Size = new System.Drawing.Size(75, 16);
            this.textLabel5.TabIndex = 9;
            this.textLabel5.Text = "Comments";
            // 
            // textLabel4
            // 
            this.textLabel4.AutoSize = true;
            this.textLabel4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.textLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.textLabel4.Location = new System.Drawing.Point(26, 272);
            this.textLabel4.Name = "textLabel4";
            this.textLabel4.Size = new System.Drawing.Size(109, 21);
            this.textLabel4.TabIndex = 8;
            this.textLabel4.Text = "Total Price:";
            // 
            // textLabel3
            // 
            this.textLabel3.AutoSize = true;
            this.textLabel3.Font = new System.Drawing.Font("Arial", 12F);
            this.textLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textLabel3.Location = new System.Drawing.Point(31, 201);
            this.textLabel3.Name = "textLabel3";
            this.textLabel3.Size = new System.Drawing.Size(29, 18);
            this.textLabel3.TabIndex = 7;
            this.textLabel3.Text = "Tip";
            // 
            // textLabel2
            // 
            this.textLabel2.AutoSize = true;
            this.textLabel2.Font = new System.Drawing.Font("Arial", 12F);
            this.textLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textLabel2.Location = new System.Drawing.Point(31, 176);
            this.textLabel2.Name = "textLabel2";
            this.textLabel2.Size = new System.Drawing.Size(37, 18);
            this.textLabel2.TabIndex = 6;
            this.textLabel2.Text = "VAT";
            // 
            // textLabel1
            // 
            this.textLabel1.AutoSize = true;
            this.textLabel1.Font = new System.Drawing.Font("Arial", 12F);
            this.textLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textLabel1.Location = new System.Drawing.Point(31, 151);
            this.textLabel1.Name = "textLabel1";
            this.textLabel1.Size = new System.Drawing.Size(104, 18);
            this.textLabel1.TabIndex = 5;
            this.textLabel1.Text = "Price of items";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.Color.White;
            this.lblPayment.Font = new System.Drawing.Font("Arial", 15F);
            this.lblPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.lblPayment.Location = new System.Drawing.Point(27, 100);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(161, 23);
            this.lblPayment.TabIndex = 4;
            this.lblPayment.Text = "Payment Table: x";
            // 
            // textBody1
            // 
            this.textBody1.AutoSize = true;
            this.textBody1.Font = new System.Drawing.Font("Arial", 15F);
            this.textBody1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBody1.Location = new System.Drawing.Point(26, 156);
            this.textBody1.Name = "textBody1";
            this.textBody1.Size = new System.Drawing.Size(139, 23);
            this.textBody1.TabIndex = 3;
            this.textBody1.Text = "Ordered Items";
            // 
            // textHeading1
            // 
            this.textHeading1.AutoSize = true;
            this.textHeading1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.textHeading1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.textHeading1.Location = new System.Drawing.Point(25, 100);
            this.textHeading1.Name = "textHeading1";
            this.textHeading1.Size = new System.Drawing.Size(224, 29);
            this.textHeading1.TabIndex = 1;
            this.textHeading1.Text = "Payment Overview";
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
            this.navigation.Size = new System.Drawing.Size(225, 725);
            this.navigation.TabIndex = 6;
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
            this.navitem_overview.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.lbl_menu.TabIndex = 16;
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
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1004, 725);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Refreshview);
            this.Controls.Add(this.navigation);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.textBody1);
            this.Controls.Add(this.textHeading1);
            this.Controls.Add(this.listPayment);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.navigation.ResumeLayout(false);
            this.navigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPayment;
        private ChapeauUserControl.Elements.TextHeading textHeading1;
        private ChapeauUserControl.Elements.TextBody textBody1;
        private ChapeauUserControl.Elements.TextBody lblPayment;
        private System.Windows.Forms.Panel panel1;
        private ChapeauUserControl.Elements.TextLabel textLabel4;
        private ChapeauUserControl.Elements.TextLabel textLabel3;
        private ChapeauUserControl.Elements.TextLabel textLabel2;
        private ChapeauUserControl.Elements.TextLabel textLabel1;
        private System.Windows.Forms.RichTextBox txtBoxComment;
        private ChapeauUserControl.Elements.TextLabel textLabel5;
        private System.Windows.Forms.TextBox txtBoxTip;
        private ChapeauUserControl.Elements.TextLabel lblVAT;
        private ChapeauUserControl.Elements.TextLabel lblPrice;
        private ChapeauUserControl.ButtonBase btnCheckOut;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private ChapeauUserControl.Elements.TextLabel lblTotalWithVat;
        private ChapeauUserControl.ButtonBase btn_cancel;
        private System.Windows.Forms.Panel navigation;
        private System.Windows.Forms.Button Logout;
        private ChapeauUserControl.Layout.NavigationItem navitem_overview;
        private ChapeauUserControl.Elements.TextBody btn_close;
        private System.Windows.Forms.Button btn_logout;
        private ChapeauUserControl.Elements.TextBody lbl_menu;
        private ChapeauUserControl.ButtonBase Refreshview;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}