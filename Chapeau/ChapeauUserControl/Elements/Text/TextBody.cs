using ChapeauUserControl.Abstract;
using System.Drawing;
using System.Windows.Forms;


namespace ChapeauUserControl.Elements
{
    public class TextBody : Label
    {
        private readonly Colors colors = new Colors();

        public TextBody()
        {
            Font = new Font("Arial", 13, FontStyle.Regular);
            ForeColor = colors.body;
        }   
    }
}
