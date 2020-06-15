using ChapeauUserControl.Abstract;
using System.Drawing;
using System.Windows.Forms;


namespace ChapeauUserControl.Elements
{
    public class TextNavigation : Label
    {
        private readonly Colors colors = new Colors();

        public TextNavigation()
        {
            Font = new Font("Arial", 13, FontStyle.Regular);
            ForeColor = colors.body;
        }   
    }
}
