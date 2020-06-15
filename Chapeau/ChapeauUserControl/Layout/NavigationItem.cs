using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauUserControl.Abstract;

namespace ChapeauUserControl.Layout
{
    public partial class NavigationItem : UserControl
    {
        private readonly Colors colors = new Colors();
        public NavigationItem()
        {
            InitializeComponent();
            activeBorder.BackColor = colors.primary;
        }
        private string navigationText;
        public string NavigationText
        {
            get { return navigationText; }
            set { lbl_navigation.Text = value; navigationText = value; }
        }

        private bool itemActiveState;
        public bool ItemActiveState
        {
            get
            {
                return itemActiveState;
            }
            set
            {
                itemActiveState = value;

                if (value)
                {
                    activeBorder.Show();
                    BackColor = ColorTranslator.FromHtml("#43546E");
                }
                else
                {
                    activeBorder.Hide();
                    BackColor = Color.Transparent;
                }
            }
        }
    }
}
