using ChapeauUserControl.Abstract;
using System.Drawing;
using System.Windows.Forms;


namespace ChapeauUserControl.Elements
{
    public class TextHeading : Label
    {
        private readonly Colors colors = new Colors();
        public TextHeading()
        {
            Font = new Font("Arial", 18, FontStyle.Bold);
            ForeColor = colors.primary;
        }   
    }
}
