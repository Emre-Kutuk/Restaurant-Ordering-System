namespace ChapeauUserControl.Components
{
    partial class MenuOrderCard
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
            this.btn_delete = new ChapeauUserControl.ButtonBase();
            this.quantityInputOrder = new ChapeauUserControl.Elements.Form.QuantityInput();
            this.lbl_comment = new ChapeauUserControl.Elements.TextBody();
            this.lbl_name = new ChapeauUserControl.Elements.TextBody();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.IsOutline = false;
            this.btn_delete.Location = new System.Drawing.Point(569, 16);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(120, 50);
            this.btn_delete.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete items";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // quantityInputOrder
            // 
            this.quantityInputOrder.BackColor = System.Drawing.Color.White;
            this.quantityInputOrder.CurrentValue = 0;
            this.quantityInputOrder.Location = new System.Drawing.Point(393, 16);
            this.quantityInputOrder.MaxValue = 0;
            this.quantityInputOrder.MinValue = 0;
            this.quantityInputOrder.Name = "quantityInputOrder";
            this.quantityInputOrder.Size = new System.Drawing.Size(150, 50);
            this.quantityInputOrder.TabIndex = 3;
            // 
            // lbl_comment
            // 
            this.lbl_comment.AutoSize = true;
            this.lbl_comment.Font = new System.Drawing.Font("Arial", 13F);
            this.lbl_comment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_comment.Location = new System.Drawing.Point(228, 32);
            this.lbl_comment.Name = "lbl_comment";
            this.lbl_comment.Size = new System.Drawing.Size(89, 21);
            this.lbl_comment.TabIndex = 2;
            this.lbl_comment.Text = "textBody3";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Arial", 13F);
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_name.Location = new System.Drawing.Point(25, 32);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(89, 21);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "textBody1";
            // 
            // MenuOrderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.quantityInputOrder);
            this.Controls.Add(this.lbl_comment);
            this.Controls.Add(this.lbl_name);
            this.Name = "MenuOrderCard";
            this.Size = new System.Drawing.Size(710, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elements.TextBody lbl_name;
        private Elements.TextBody lbl_comment;
        private Elements.Form.QuantityInput quantityInputOrder;
        private ButtonBase btn_delete;
    }
}
