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

namespace ChapeauUserControl.Components
{
    public partial class MenuLinkItem : UserControl
    {
        private readonly Colors colors = new Colors();

        public MenuLinkItem(string itenName)
        {
            InitializeComponent();
            lbl_navigation.Text = itenName;

            activeBorder.BackColor = colors.primary;
            activeBorder.Hide();
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks menu item")]
        public event EventHandler MenuLinkItemClick;

        private void MenuLinkItem_Click(object sender, EventArgs e)
        {
            if (this.MenuLinkItemClick != null)
            {
                this.MenuLinkItemClick(this, e);
            }
        }

        private bool setActiveState;
        [Browsable(false)]
        public bool SetActiveState
        {
            get { return setActiveState; }
            set
            {
                setActiveState = value;

                if (value)
                {
                    activeBorder.Show();
                    BackColor = colors.white;
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
