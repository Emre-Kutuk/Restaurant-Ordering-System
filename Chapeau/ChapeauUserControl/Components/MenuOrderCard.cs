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
    public partial class MenuOrderCard : UserControl
    {
        private OrderItem orderItem;
        public MenuOrderCard(OrderItem orderItem)
        {
            this.orderItem = orderItem;

            InitializeComponent();
            lbl_name.Text = orderItem.MenuItem.Name;
            lbl_comment.Text = orderItem.Comment;

            quantityInputOrder.UpdateCount += (sender, EventArgs) => { UpdateCount(quantityInputOrder.CurrentValue); };

            quantityInputOrder.CurrentValue = orderItem.Count;

            quantityInputOrder.MaxValue = orderItem.MenuItem.Stock;
            quantityInputOrder.MinValue = 0;
        }

        private void UpdateCount(int value)
        {
            orderItem.Count = value;
        }

        [Browsable(false)]
        [Category("Action")]
        [Description("Invoked when user click the remove button")]
        public event EventHandler RemoveItem;
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.RemoveItem != null)
                this.RemoveItem(this, e);
        }
    }
}
