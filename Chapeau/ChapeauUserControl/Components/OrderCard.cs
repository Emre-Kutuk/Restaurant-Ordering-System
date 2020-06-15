using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;

namespace ChapeauUserControl.Components
{
    public partial class OrderCard : UserControl
    {
        private Order order;
        public OrderCard(Order order)
        {
            InitializeComponent();
            this.order = order;
            // display info
            DisplayInfo();
        }

        private void DisplayInfo()
        {
            Lbl_tableNr.Text = order.Table.TableId.ToString();
        }


        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;


        protected void button21_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
    }
}
