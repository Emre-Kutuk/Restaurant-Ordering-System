namespace ChapeauUserControl.Layout
{
    partial class NavigationItem
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
            this.SuspendLayout();
            // 
            // activeBorder
            // 
            this.activeBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.activeBorder.ForeColor = System.Drawing.Color.Transparent;
            this.activeBorder.Location = new System.Drawing.Point(0, 0);
            this.activeBorder.Name = "activeBorder";
            this.activeBorder.Size = new System.Drawing.Size(2, 55);
            this.activeBorder.TabIndex = 1;
            // 
            // lbl_navigation
            // 
            this.lbl_navigation.AutoSize = true;
            this.lbl_navigation.Font = new System.Drawing.Font("Arial", 13F);
            this.lbl_navigation.ForeColor = System.Drawing.Color.White;
            this.lbl_navigation.Location = new System.Drawing.Point(48, 16);
            this.lbl_navigation.Name = "lbl_navigation";
            this.lbl_navigation.Size = new System.Drawing.Size(123, 21);
            this.lbl_navigation.TabIndex = 0;
            this.lbl_navigation.Text = "textNavigation";
            // 
            // NavigationItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.Controls.Add(this.activeBorder);
            this.Controls.Add(this.lbl_navigation);
            this.Name = "NavigationItem";
            this.Size = new System.Drawing.Size(225, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elements.TextNavigation lbl_navigation;
        private System.Windows.Forms.Panel activeBorder;
    }
}
