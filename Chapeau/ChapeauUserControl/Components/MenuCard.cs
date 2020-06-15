using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel.Menu;
using ChapeauUserControl.Abstract;

namespace ChapeauUserControl.Components
{
    public partial class MenuCard : UserControl
    {
        private readonly Colors colors = new Colors();

        public MenuCard(ChapeauModel.MenuItem item)
        {
            InitializeComponent();
            lbl_itemName.Text = item.Name;
            lbl_stock.Text = item.Stock > 0 ? item.Stock.ToString() : "Out Of Stock";
            lbl_price.Text = "€" + item.Price.ToString("0.00");
        }


        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks menu item")]
        public event EventHandler MenuCardClick;

        private void MenuCard_Click(object sender, EventArgs e)
        {
            if (this.MenuCardClick != null)
            {
                this.MenuCardClick(this, e);
            }

            setActiveState = true;
        }

        private bool setActiveState;
        [Browsable(false)]
        public bool SetActiveState {
            get { return setActiveState; }
            set {
                setActiveState = value;

                if (value)
                {
                    BackColor = colors.primary;
                    
                    lbl_itemName.ForeColor = colors.white;
                    lbl_stock.ForeColor = colors.white;
                    lbl_price.ForeColor = colors.white;
                }
                else
                {
                    BackColor = Color.Transparent;

                    lbl_itemName.ForeColor = colors.body;
                    lbl_stock.ForeColor = colors.body;
                    lbl_price.ForeColor = colors.body;
                }
            }
        }
    }
}
