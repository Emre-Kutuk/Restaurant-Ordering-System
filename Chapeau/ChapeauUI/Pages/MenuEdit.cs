using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauLogic;
using ChapeauModel;
using System.Windows.Forms;
using ChapeauModel.Menu;
using MainMenu = ChapeauModel.Menu.MainMenu;

namespace ChapeauUI.Pages
{
    public partial class MenuEdit : Form
    {
        ChapeauLogic.Menu_Service menu_Service = new ChapeauLogic.Menu_Service();
        private ChapeauModel.MenuItem currentMenuItem;


        public MenuEdit()
        {
            InitializeComponent();
            ShowPanel("Menu_Edit");
            listView_menu_edit.Show();
            navigation.Hide();
        }
        private void ShowPanel(string panelName)
        {
            if (panelName == "Menu_Edit")
            {
                // show drinks panel
                pnl_menu_edit.Show();
                //fill list with items
                List<MainMenu> menus = menu_Service.GetFullMenu();
                // clear the listview before filling it again
                listView_menu_edit.Clear();
                //add columns to listview
                listView_menu_edit.Columns.Add("Item Name");
                listView_menu_edit.Columns.Add("Category");
                listView_menu_edit.Columns.Add("Price");
                listView_menu_edit.Columns.Add("Stock");
                //add items to listview
                foreach (MainMenu m in menus)
                {
                    foreach (MenuCategorie mc in m.MenuCategories)
                    {
                        foreach (ChapeauModel.MenuItem mi in mc.MenuItems)
                        {
                            //printing...
                            string[] items = new string[] {
                                mi.Name.ToString(),
                                mc.CategorieName.ToString(),
                                mi.Price.ToString("0.00"),
                                mi.Stock.ToString(),
                            };

                            ListViewItem li = new ListViewItem(items);
                            li.Tag = mi;


                            listView_menu_edit.Items.Add(li);

                        }
                    }
                }
                //column header resize
                listView_menu_edit.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                //clear text box and label
                stock_txt.Clear();
                lbl_itemName.Text = "";
            }
        }

        private void navitem_employee_Click(object sender, EventArgs e)
        {
            Employee_Edit edit = new Employee_Edit();
            edit.Show();
            this.Close();
        }

        private void btn_editStock_Click(object sender, EventArgs e)
        {
            if (listView_menu_edit.SelectedItems.Count > 0 && stock_txt.Text != "")
            {
                // recording changed stock
                currentMenuItem.Stock = int.Parse(stock_txt.Text);
                //calling change stock method from menu dao
                menu_Service.ChangeStock(currentMenuItem.Name, currentMenuItem.Stock);
                MessageBox.Show("Stock Changed");
                ShowPanel("Menu_Edit");
            }
            else
            {
                MessageBox.Show("Select an Item, and do not leave the stock input empty");
            }
        }

        private void listView_menu_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_menu_edit.SelectedItems.Count > 0)
            {
                //storing selected items
                currentMenuItem = (ChapeauModel.MenuItem)listView_menu_edit.SelectedItems[0].Tag;
                //viewing items selected in txt & lbl boxes
                stock_txt.Text = currentMenuItem.Stock.ToString();
                lbl_itemName.Text = currentMenuItem.Name.ToString();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lbl_menu_Click(object sender, EventArgs e)
        {
            navigation.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            navigation.Hide();
        }

        private void Refreshview_Click(object sender, EventArgs e)
        {
            ShowPanel("Menu_Edit");
        }
    }
}
