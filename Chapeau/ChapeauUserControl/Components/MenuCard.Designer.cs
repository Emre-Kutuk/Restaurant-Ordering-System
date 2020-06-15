namespace ChapeauUserControl.Components
{
    partial class MenuCard
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
            this.lbl_price = new ChapeauUserControl.Elements.TextBody();
            this.lbl_stock = new ChapeauUserControl.Elements.TextBody();
            this.lbl_itemName = new ChapeauUserControl.Elements.TextBody();
            this.SuspendLayout();
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Arial", 15F);
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.lbl_price.Location = new System.Drawing.Point(563, 27);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(98, 23);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "textBody2";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Arial", 15F);
            this.lbl_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.lbl_stock.Location = new System.Drawing.Point(346, 27);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(98, 23);
            this.lbl_stock.TabIndex = 1;
            this.lbl_stock.Text = "textBody2";
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.AutoSize = true;
            this.lbl_itemName.Font = new System.Drawing.Font("Arial", 15F);
            this.lbl_itemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.lbl_itemName.Location = new System.Drawing.Point(31, 27);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(98, 23);
            this.lbl_itemName.TabIndex = 0;
            this.lbl_itemName.Text = "textBody1";
            // 
            // MenuCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.lbl_itemName);
            this.Name = "MenuCard";
            this.Size = new System.Drawing.Size(697, 80);
            this.Click += new System.EventHandler(this.MenuCard_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elements.TextBody lbl_itemName;
        private Elements.TextBody lbl_stock;
        private Elements.TextBody lbl_price;
    }
}
