using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUserControl.Elements.Form
{
    public partial class QuantityInput : UserControl
    {
        private int currentValue;
        private int maxValue;

        public int CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; lbl_quantity.Text = value.ToString(); }
        }
        public int MaxValue {
            get { return maxValue; }  
            set
            {
                maxValue = value;
                btn_increase.Enabled = value > 0 && CurrentValue != maxValue;
            } 
        }
        private int minValue;
        public int MinValue {
            get { return minValue; }
            set {
                minValue = value;
                btn_decrease.Enabled = CurrentValue > 0;
            }
        }

        /*
         * Create a custom EventHandler to bubble up the event to the parent.
        */
        [Browsable(false)] // false, so it is not viewable in the properties of Visual Studio
        [Description("Invoked when user click changes value of the quantity")]
        public event EventHandler UpdateCount;

        public QuantityInput()
        {
            InitializeComponent();
            btn_decrease.Enabled = false;
        }

        private void btn_decrease_Click(object sender, EventArgs e)
        {
            CurrentValue = int.Parse(lbl_quantity.Text) - 1;

            btn_increase.Enabled = CurrentValue < MaxValue;
            btn_decrease.Enabled = CurrentValue > MinValue;


            UpdateData(sender, e);
        }

        private void btn_increase_Click(object sender, EventArgs e)
        {
            CurrentValue = int.Parse(lbl_quantity.Text) + 1;

            btn_increase.Enabled = CurrentValue < MaxValue;
            btn_decrease.Enabled = CurrentValue > MinValue;

            UpdateData(sender, e);
        }

        /*
         * Because a _click method in Windows Form does not register when you click on an element inside a usercontrol from the parent.
         * We need to register the _click to the buttons inside the usercontrol, otherwise the event will not get registered.
        */
        private void UpdateData(object sender, EventArgs e)
        {
            if (this.UpdateCount != null)
                this.UpdateCount(this, e);
        }
    }
}
