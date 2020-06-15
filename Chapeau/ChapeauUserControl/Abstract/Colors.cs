using System.Drawing;

namespace ChapeauUserControl.Abstract
{
    public enum EnumColors
    {
        Primary,
        Secondary,
        Tetriary,
        Body
    }
    public class Colors
    {
        public Color primary = ColorTranslator.FromHtml("#00B9FF");
        public Color secondary = ColorTranslator.FromHtml("#3A4A61");
        public Color body = ColorTranslator.FromHtml("#00274E");
        public Color white = ColorTranslator.FromHtml("#FFFFFF");
        public Color darkblue = ColorTranslator.FromHtml("#3A4A61");
    }
}
