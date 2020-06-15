using ChapeauUserControl.Abstract;
using System.Drawing;
using System.Windows.Forms;


namespace ChapeauUserControl.Elements
{
    public class TextLabel : Label
    {
        private readonly Colors colors = new Colors();

        public TextLabel()
        {
            Font = new Font("Arial", 12, FontStyle.Regular);
            ForeColor = colors.body;
        }
    }
}
