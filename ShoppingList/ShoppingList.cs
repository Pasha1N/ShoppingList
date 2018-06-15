using System;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class windowShoppingList : Form
    {
        public windowShoppingList()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            item.Text = item.Text.Trim();
            shoppingList.Items.Add(item.Text);
            add.Enabled = false;
            item.Text = null;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            shoppingList.Items.Insert(shoppingList.SelectedIndex + 2, shoppingList.Items[shoppingList.SelectedIndex]);
            shoppingList.SetSelected(shoppingList.SelectedIndex + 2, true);
            shoppingList.Items.RemoveAt(shoppingList.SelectedIndex - 2);
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            shoppingList.Items.Insert(shoppingList.SelectedIndex - 1, shoppingList.Items[shoppingList.SelectedIndex]);
            shoppingList.SetSelected(shoppingList.SelectedIndex - 2, true);
            shoppingList.Items.RemoveAt(shoppingList.SelectedIndex + 2);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            shoppingList.Items.RemoveAt(shoppingList.SelectedIndex);
            delete.Enabled = false;
            buttonUp.Enabled = false;
            buttonDown.Enabled = false;
        }

        private void item_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < item.Text.Length; i++)
            {
                if (!char.IsSeparator(item.Text[i]))
                {
                    add.Enabled = true;
                    break;
                }
                else
                {
                    add.Enabled = false;
                }
            }

            string copyItem = item.Text;
            copyItem = copyItem.Trim();

            foreach (object element in shoppingList.Items)
            {
                string copyElement = element.ToString();

                if (copyElement == copyItem)
                {
                    add.Enabled = false;
                    break;
                }
                else
                {
                    add.Enabled = true;
                }
            }

            if (item.Text.Length == 0)
            {
                add.Enabled = false;
            }
        }

        private void shoppingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete.Enabled = true;
            buttonUp.Enabled = shoppingList.SelectedIndex > 0 ? true : false;
            buttonDown.Enabled = shoppingList.SelectedIndex < shoppingList.Items.Count - 1 ? true : false;
        }
    }
}