using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ChapeauUserControl.Elements.Form
{
    public class Input : TextBox
    {
        [Description("Placeholder text displayed in the textbox"), Category("Appearance")]
        public string PlaceholderText { get; set; }
        public Input()
        {
            AutoSize = true;
            Text = PlaceholderText;
            Size = new Size(100, 50);
            Font = new Font("Arial", 12, FontStyle.Regular);
        }

        protected override void OnLeave(EventArgs e)
        {
            if (Text == "")
            {
                Text = PlaceholderText;
                ForeColor = Color.Gray;
            }
            base.OnLeave(e);
        }
        protected override void OnEnter(EventArgs e)
        {
            if (Text == PlaceholderText)
            {
                Text = null;
                ForeColor = Color.Black;
            }
            base.OnLeave(e);
        }
    }
}
