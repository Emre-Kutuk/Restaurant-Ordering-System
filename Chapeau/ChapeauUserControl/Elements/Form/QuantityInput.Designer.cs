namespace ChapeauUserControl.Elements.Form
{
    partial class QuantityInput
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
            this.lbl_quantity = new ChapeauUserControl.Elements.TextBody();
            this.btn_increase = new ChapeauUserControl.ButtonBase();
            this.btn_decrease = new ChapeauUserControl.ButtonBase();
            this.SuspendLayout();
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Arial", 15F);
            this.lbl_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(78)))));
            this.lbl_quantity.Location = new System.Drawing.Point(65, 14);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(21, 23);
            this.lbl_quantity.TabIndex = 2;
            this.lbl_quantity.Text = "0";
            // 
            // btn_increase
            // 
            this.btn_increase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btn_increase.FlatAppearance.BorderSize = 0;
            this.btn_increase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_increase.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_increase.ForeColor = System.Drawing.Color.White;
            this.btn_increase.IsOutline = false;
            this.btn_increase.Location = new System.Drawing.Point(0, 0);
            this.btn_increase.Name = "btn_increase";
            this.btn_increase.Size = new System.Drawing.Size(50, 50);
            this.btn_increase.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_increase.TabIndex = 1;
            this.btn_increase.Text = "+";
            this.btn_increase.UseVisualStyleBackColor = true;
            this.btn_increase.Click += new System.EventHandler(this.btn_increase_Click);
            // 
            // btn_decrease
            // 
            this.btn_decrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btn_decrease.FlatAppearance.BorderSize = 0;
            this.btn_decrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decrease.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_decrease.ForeColor = System.Drawing.Color.White;
            this.btn_decrease.IsOutline = false;
            this.btn_decrease.Location = new System.Drawing.Point(100, 0);
            this.btn_decrease.Name = "btn_decrease";
            this.btn_decrease.Size = new System.Drawing.Size(50, 50);
            this.btn_decrease.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_decrease.TabIndex = 0;
            this.btn_decrease.Text = "-";
            this.btn_decrease.UseVisualStyleBackColor = true;
            this.btn_decrease.Click += new System.EventHandler(this.btn_decrease_Click);
            // 
            // QuantityInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.btn_increase);
            this.Controls.Add(this.btn_decrease);
            this.Name = "QuantityInput";
            this.Size = new System.Drawing.Size(150, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBody lbl_quantity;
        private ButtonBase btn_decrease;
        private ButtonBase btn_increase;
    }
}
