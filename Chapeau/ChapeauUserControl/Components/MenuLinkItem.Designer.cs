namespace ChapeauUserControl.Components
{
    partial class MenuLinkItem
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
            this.activeBorder = new System.Windows.Forms.Panel();
            this.lbl_navigation = new ChapeauUserControl.Elements.TextNavigation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // activeBorder
            // 
            this.activeBorder.ForeColor = System.Drawing.Color.Transparent;
            this.activeBorder.Location = new System.Drawing.Point(0, 0);
            this.activeBorder.Name = "activeBorder";
            this.activeBorder.Size = new System.Drawing.Size(2, 55);
            this.activeBorder.TabIndex = 3;
            // 
            // lbl_navigation
            // 
            this.lbl_navigation.AutoSize = true;
            this.lbl_navigation.Font = new System.Drawing.Font("Arial", 13F);
            this.lbl_navigation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_navigation.Location = new System.Drawing.Point(47, 17);
            this.lbl_navigation.Name = "lbl_navigation";
            this.lbl_navigation.Size = new System.Drawing.Size(123, 21);
            this.lbl_navigation.TabIndex = 2;
            this.lbl_navigation.Text = "textNavigation";
            this.lbl_navigation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 1);
            this.panel1.TabIndex = 4;
            // 
            // MenuLinkItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.activeBorder);
            this.Controls.Add(this.lbl_navigation);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "MenuLinkItem";
            this.Size = new System.Drawing.Size(222, 57);
            this.Click += new System.EventHandler(this.MenuLinkItem_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel activeBorder;
        private Elements.TextNavigation lbl_navigation;
        private System.Windows.Forms.Panel panel1;
    }
}
