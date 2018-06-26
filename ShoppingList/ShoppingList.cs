using System;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class ShoppingList : Form
    {
        public ShoppingList()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            item.Text = item.Text.Trim();
            shoppingList.Items.Add(item.Text);
            add.Enabled = false;
            item.Text = null;
        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            bool isMarked = false;
            foreach (int item in shoppingList.CheckedIndices)
            {
                if (shoppingList.SelectedIndex == item)
                {
                    isMarked = true;
                    break;
                }
            }

            shoppingList.Items.Insert(shoppingList.SelectedIndex + 2, shoppingList.Items[shoppingList.SelectedIndex]);

            if (isMarked)
            {
                shoppingList.SetItemChecked(shoppingList.SelectedIndex + 2, true);
            }

            shoppingList.SetSelected(shoppingList.SelectedIndex + 2, true);
            shoppingList.Items.RemoveAt(shoppingList.SelectedIndex - 2);
        }

        private void ButtonUp_Click(object sender, EventArgs e)
        {
            bool isMarked = false;

            foreach (int item in shoppingList.CheckedIndices)
            {
                if (shoppingList.SelectedIndex == item)
                {
                    isMarked = true;
                    break;
                }
            }

            shoppingList.Items.Insert(shoppingList.SelectedIndex - 1, shoppingList.Items[shoppingList.SelectedIndex]);

            if (isMarked)
            {
                shoppingList.SetItemChecked(shoppingList.SelectedIndex - 2, true);
            }

            shoppingList.SetSelected(shoppingList.SelectedIndex - 2, true);
            shoppingList.Items.RemoveAt(shoppingList.SelectedIndex + 2);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            shoppingList.Items.RemoveAt(shoppingList.SelectedIndex);
            delete.Enabled = false;
            buttonUp.Enabled = false;
            buttonDown.Enabled = false;

            CheckForSimilarity();
        }

        private void Item_TextChanged(object sender, EventArgs e)
        {
            CheckForSimilarity();
        }

        private void ShoppingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete.Enabled = true;
            buttonUp.Enabled = shoppingList.SelectedIndex > 0;
            buttonDown.Enabled = shoppingList.SelectedIndex < shoppingList.Items.Count - 1;
        }

        public void CheckForSimilarity()
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
    }
}