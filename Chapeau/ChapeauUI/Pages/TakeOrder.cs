using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel.Menu;
using ChapeauUserControl.Components;
using ChapeauModel;
using MainMenu = ChapeauModel.Menu.MainMenu;


namespace ChapeauUI.Pages
{
    public partial class TakeOrder : Form
    {
        private int panelIndex = 1;
        private List<OrderItem> orderedItemsList = new List<OrderItem>();
        private ChapeauModel.MenuItem currentMenuItem;

        private Employee employee;
        private RestaurantTable table;
        private Order_Service order_service;

        public TakeOrder(Employee employee, RestaurantTable table)
        {
            InitializeComponent();

            ShowCorrectPanel(1);

            flowLayoutPanelMenu.Controls.Clear();
            PopulateMenu();

            navigation.Hide();

            order_service = new Order_Service();
            this.employee = employee;
            this.table = table;

            lbl_tableNumber.Text = table.TableId.ToString();
            lbl_ActiveMenu.Text = "";
        }

        public void ClearOrderList()
        {
            orderedItemsList.Clear();
            flowLayoutPanelOrderedItems.Controls.Clear();
        }

        // Remove active state of all 'MenuLinkItem' usercontrols
        private void RemoveActiveCategorieState()
        {
            foreach (MenuLinkItem item in flowLayoutPanelMenuCategorie.Controls)
            {
                item.SetActiveState = false;
            }
        }
        // Remove active state of all 'MenuCard' usercontrols
        private void RemoveActiveMenuCardState()
        {
            foreach (MenuCard item in flowLayoutPanelMenuItem.Controls)
            {
                item.SetActiveState = false;
            }
        }

        private void ResetInputValues()
        {
            quantityInput.CurrentValue = 0;
            input_comment.Text = "Comment...";
        }

        // Check if comment is not equal to the placeholder text.
        private string GetComment()
        {
            return input_comment.Text != "Comment..." ? input_comment.Text : "";
        }

        /* 
         * Menu Main
        */
        private void PopulateMenu()
        {
            if (flowLayoutPanelMenu.Controls.Count == 0)
            {
                Menu_Service menu_service = new Menu_Service();

                // Get all menu items from the database
                List<MainMenu> menuList = menu_service.GetFullMenu();

                foreach (MainMenu menu in menuList)
                {
                    // Create a custom usercontrol with the data from the 'Drinks, Dinner, and Lunch' menu, for the windows forms app.
                    MenuLinkItem menuLink = new MenuLinkItem(menu.MenuName);

                    // Add a custom eventHandler to show the categories corresponding with the clicked menu 
                    menuLink.MenuLinkItemClick += (sender, EventArgs) => {
                        MenuLinkItem_Click(menu.MenuCategories);
                        lbl_ActiveMenu.Text = menu.MenuName + " Menu";
                    };

                    flowLayoutPanelMenu.Controls.Add(menuLink);
                }
            }
        }
        private void MenuLinkItem_Click(List<MenuCategorie> menuCategorieList)
        {
            // Show correct panel
            ShowCorrectPanel(2);
            // Remove all the items shown of the categories, so you do not, for example, see the items from the previous opened categorie.
            flowLayoutPanelMenuItem.Controls.Clear();
            // Fill the categorie panel with user controls
            PopulateCategorieList(menuCategorieList);
        }

        /* 
         * Menu Categories
        */
        private void PopulateCategorieList(List<MenuCategorie> menuCategorieList)
        {
            flowLayoutPanelMenuCategorie.Controls.Clear();

            foreach (MenuCategorie categorie in menuCategorieList)
            {
                MenuLinkItem menuLink = new MenuLinkItem(categorie.CategorieName);

                menuLink.MenuLinkItemClick += (sender, EventArgs) => {
                    MenuCategorieLinkItem_Click(categorie.MenuItems);
                    // Set the active state to true, so we can change the styling
                    menuLink.SetActiveState = true;
                };

                flowLayoutPanelMenuCategorie.Controls.Add(menuLink);
            }
        }

        private void MenuCategorieLinkItem_Click(List<ChapeauModel.MenuItem> menuItemList)
        {
            // Remove all active styling from the user components, so we can show the correct one
            RemoveActiveCategorieState();
            ShowCorrectPanel(2);
            PopulateMenuItemList(menuItemList);
        }

        /* 
         * Menu Items
        */
        private void PopulateMenuItemList(List<ChapeauModel.MenuItem> menuItemList)
        {
            flowLayoutPanelMenuItem.Controls.Clear();

            foreach (ChapeauModel.MenuItem menuItem in menuItemList)
            {
                MenuCard menuCard = new MenuCard(menuItem);

                menuCard.MenuCardClick += (sender, EventArgs) => {
                    // Set the active card to the data of the menu item, so we do not have to work with the user control
                    SetActiveCard(menuItem);
                    menuCard.SetActiveState = true;
                };

                flowLayoutPanelMenuItem.Controls.Add(menuCard);
            }
        }
        private void SetActiveCard(ChapeauModel.MenuItem menuItem)
        {
            RemoveActiveMenuCardState();
            /* 
             * We need to set currentMenuItem variable to the 'menuItem'.
             * Otherwise the 'comment' textbox does not know what item is active, because we use 1 textbox for all items.
            */
            currentMenuItem = menuItem;

            // Set the custom quantityinput user control max value to that of the stock.
            quantityInput.MaxValue = currentMenuItem.Stock;
            quantityInput.MinValue = 0;

            // Everytime the quantity is changed call the methods, to update the orderlist
            quantityInput.UpdateCount += (sender, EventArgs) => {
                // If quantity currentvalue is bigger than 0, add the item to the order
                if (quantityInput.CurrentValue > 0)
                {
                    AddItemToOrderList(currentMenuItem, quantityInput.CurrentValue);
                }
                // If it is 0, remove it, and put the quantityinput and comment textbox back to the default values
                else
                {
                    RemoveItemFromOrderList(currentMenuItem);
                    ResetInputValues();
                }
            };

            // update quantityinput and comment textbox values
            UpdateInputValues(menuItem);
        }

        /* 
         * Order Items
        */
        private void PopulateOrderedItemList()
        {
            flowLayoutPanelOrderedItems.Controls.Clear();

            if (orderedItemsList.Count > 0)
            {
                foreach (OrderItem orderItem in orderedItemsList)
                {
                    // Because in our design the ordered items look different than the menu items, we need to use a new usercontrol
                    MenuOrderCard orderCardItem = new MenuOrderCard(orderItem);

                    // Create a custom eventhadler that removes all the items from the orderlist, panel, and puts the inputs, back to the default value
                    orderCardItem.RemoveItem += (sender, EventArgs) =>
                    {
                        orderedItemsList.Remove(orderItem);
                        flowLayoutPanelOrderedItems.Controls.Remove(orderCardItem);
                        ResetInputValues();
                    };

                    flowLayoutPanelOrderedItems.Controls.Add(orderCardItem);
                }
            }
        }

        /*
         * Because we make use of one textbox, and quantity input, we need to check if the active item is already in the orderlist,
         * because thats where the 'comment' and 'count' is stored.
         * 
         * If the menuItem is in the orderedItemsList we update the values, otherwise it gets put back to the default.
        */
        private void UpdateInputValues(ChapeauModel.MenuItem menuItem)
        {
            foreach (OrderItem item in orderedItemsList)
            {
                if (item.MenuItem.ItemId == menuItem.ItemId)
                {
                    input_comment.Text = item.Comment;
                    quantityInput.CurrentValue = item.Count;
                    return;
                }
            }

            ResetInputValues();
        }

        /*
         * Because the user needs to add comments, also after he/she added the quantity, we need to loop over the orderlist
         * and add the comment to the order item if it is in the list.
        */
        private void AddCommentToOrder()
        {
            foreach (OrderItem item in orderedItemsList)
            {
                if (item.MenuItem.ItemId == currentMenuItem.ItemId)
                {
                    item.Comment = GetComment();
                    return;
                }
            }
        }

        private void AddItemToOrderList(ChapeauModel.MenuItem menuItem, int currentQuantity)
        {
            // try finding if the order is already in the orderlist, if so, increase the Count.
            foreach (OrderItem item in orderedItemsList)
            {
                if (item.MenuItem.ItemId == menuItem.ItemId)
                {
                    item.Count = currentQuantity;
                    item.Comment = GetComment();
                    return;
                }
            }
            DateTime time = DateTime.Now;
            // If it is not in the orderlist add it.
            OrderItem orderItem = new OrderItem(menuItem, 1, GetComment(), OrderStatus.Taken, time, 0);
            orderedItemsList.Add(orderItem);
        }

        /*
         * Although we have a 'delete' button for an order, but if the user descreases the count to 0, we also need to remove it.
         * We loop over the list, and if the ItemId is found we remove it.
        */
        public void RemoveItemFromOrderList(ChapeauModel.MenuItem menuItem)
        {
            foreach (OrderItem item in orderedItemsList)
            {
                if (item.MenuItem.ItemId == menuItem.ItemId)
                {
                    orderedItemsList.Remove(item);
                    return;
                }
            }
        }

        /*
         * Submit order
        */
        private void btn_order_Click(object sender, EventArgs e)
        {
            // If there are ordered items in the list
            if (orderedItemsList.Count > 0)
            {
                SubmitOrder();
            }
        }
        private void SubmitOrder()
        {
            try
            {
                // Add the order
                order_service.AddOrder(table, employee, orderedItemsList);
                // Reset inpute values
                ResetInputValues();
                // Remove active states
                RemoveActiveMenuCardState();
                // Clear order list
                ClearOrderList();
                // Reset currentMenuItem
                currentMenuItem = null;

                MessageBox.Show(
                  "Order is succefully placed", // Exception Message
                  "Order succefull", // Message box caption (title)
                  MessageBoxButtons.OK, // Close button that return an exit code of '0'.
                  MessageBoxIcon.Information // Message box theme.
                );

                Overview overview = new Overview(employee);
                overview.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                  ex.Message, // Exception Message
                  "Adding order process error.", // Message box caption (title)
                  MessageBoxButtons.OK, // Close button that return an exit code of '0'.
                  MessageBoxIcon.Error // Message box theme.
                );
            }
        }

        /*
         * Our design makes use of a back button
         * 'back' is not only from categories items to menu parent, but also from 'ordered items' to the last visitted panel.
         * This is why we make use of integers. the current panel index gets saved to 'panelIndex', so when the back button is clicked
         * We can do '--panelIndex' to go back to the last page.
        */
        private void ShowCorrectPanel(int panelIndex)
        {
            flowLayoutPanelMenu.Hide();
            flowLayoutPanelMenuCategorie.Hide();
            flowLayoutPanelMenuItem.Hide();
            flowLayoutPanelOrderedItems.Hide();
            lbl_item_name.Hide();
            lbl_price.Hide();
            lbl_stock.Hide();

            if (panelIndex == 0)
            {
                Overview overview = new Overview(employee);
                overview.Show();

                this.Close();
            } else if (panelIndex == 1)
            {
                flowLayoutPanelMenu.Show();
            }
            else if (panelIndex == 2)
            {
                flowLayoutPanelMenuCategorie.Show();
                flowLayoutPanelMenuItem.Show();
                lbl_item_name.Show();
                lbl_price.Show();
                lbl_stock.Show();
            }
            else if (panelIndex == 3)
            {
                flowLayoutPanelMenuCategorie.Show();
                flowLayoutPanelOrderedItems.Show();
                flowLayoutPanelOrderedItems.BringToFront();
            }

            this.panelIndex = panelIndex;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ShowCorrectPanel(--panelIndex);
        }

        private void input_comment_Leave(object sender, EventArgs e)
        {
            if (currentMenuItem is ChapeauModel.MenuItem)
            {
                AddCommentToOrder();
            }
        }

        private void btn_showOrder_Click(object sender, EventArgs e)
        {
            if (btn_showOrder.Text == "Show ordered items")
            {
                ShowCorrectPanel(3);
                PopulateOrderedItemList();
                btn_showOrder.Text = "Back to menu items";
            }
            else
            {
                ShowCorrectPanel(2);
                btn_showOrder.Text = "Show ordered items";
            }
        }

        private void btn_remove_all_Click(object sender, EventArgs e)
        {
            ClearOrderList();
            RemoveActiveMenuCardState();
            ResetInputValues();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ShowCorrectPanel(1);

            flowLayoutPanelMenu.Controls.Clear();
            PopulateMenu();

            lbl_tableNumber.Text = table.TableId.ToString();
            lbl_ActiveMenu.Text = "";
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

        private void navitem_overview_Click(object sender, EventArgs e)
        {
            Overview overview = new Overview(employee);
            overview.Show();

            this.Close();
        }
    }
}