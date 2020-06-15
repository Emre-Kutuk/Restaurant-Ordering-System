namespace ChapeauUserControl.Components
{
    partial class OrderCard
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
            this.lbl_status = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.Lbl_tableNr = new System.Windows.Forms.Label();
            this.button21 = new ChapeauUserControl.ButtonBase();
            this.text4 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Arial", 15F);
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(34)))));
            this.lbl_status.Location = new System.Drawing.Point(427, 26);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 23);
            this.lbl_status.TabIndex = 7;
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.text3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(100)))), ((int)(((byte)(83)))));
            this.text3.Location = new System.Drawing.Point(355, 26);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(85, 26);
            this.text3.TabIndex = 6;
            this.text3.Text = "Status:";
            // 
            // Lbl_tableNr
            // 
            this.Lbl_tableNr.AutoSize = true;
            this.Lbl_tableNr.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.Lbl_tableNr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(100)))), ((int)(((byte)(83)))));
            this.Lbl_tableNr.Location = new System.Drawing.Point(133, 23);
            this.Lbl_tableNr.Name = "Lbl_tableNr";
            this.Lbl_tableNr.Size = new System.Drawing.Size(0, 26);
            this.Lbl_tableNr.TabIndex = 5;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.IsOutline = false;
            this.button21.Location = new System.Drawing.Point(434, 133);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(100, 30);
            this.button21.Style = ChapeauUserControl.Abstract.EnumColors.Primary;
            this.button21.TabIndex = 4;
            this.button21.Text = "button21";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Font = new System.Drawing.Font("Arial", 12F);
            this.text4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.text4.Location = new System.Drawing.Point(183, 140);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(41, 18);
            this.text4.TabIndex = 3;
            this.text4.Text = "text4";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Arial", 15F);
            this.text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(34)))));
            this.text2.Location = new System.Drawing.Point(27, 140);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(53, 23);
            this.text2.TabIndex = 1;
            this.text2.Text = "text2";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.text1.Location = new System.Drawing.Point(26, 23);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(122, 29);
            this.text1.TabIndex = 0;
            this.text1.Text = "Table NR.";
            // 
            // OrderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.Lbl_tableNr);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Name = "OrderCard";
            this.Size = new System.Drawing.Size(549, 185);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text4;
        private ButtonBase button21;
        private System.Windows.Forms.Label Lbl_tableNr;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label lbl_status;
    }
}
