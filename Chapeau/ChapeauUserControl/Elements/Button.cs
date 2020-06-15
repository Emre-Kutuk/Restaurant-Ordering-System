using ChapeauUserControl.Abstract;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ChapeauUserControl
{
    public class ButtonBase : Button
    {
        private EnumColors style = EnumColors.Primary;
        private bool isOutline = false;
        private readonly Colors colors = new Colors();

        [Description("Button style displayed in the application"), Category("Appearance"), Browsable(true)]
        public EnumColors Style
        {
            get { return style; }
            set
            {
                style = value;
                ForeColor = colors.primary;
                IsOutline = isOutline;
            }
        }

        [Description("Button has border style"), Category("Appearance"), Browsable(true)]
        public bool IsOutline
        {
            get { return isOutline; }
            set
            {
                if (value)
                {
                    BackColor = Color.Transparent;
                    ForeColor = colors.primary;
                    FlatAppearance.BorderSize = 1;
                }
                else
                {
                    BackColor = colors.primary;
                    ForeColor = Color.White;
                    FlatAppearance.BorderSize = 0;
                }

                isOutline = value;
            }
        }


        public ButtonBase()
        {
            FlatStyle = FlatStyle.Flat;
            Size = new Size(100, 30);
            UseVisualStyleBackColor = true;
            Font = new Font("Arial", 12, FontStyle.Regular);
        }
    }
}