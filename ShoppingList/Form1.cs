using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class windowShoppingList : Form
    {
        public windowShoppingList()
        {
            InitializeComponent();
        }

        private void item_TextChanged(object sender, EventArgs e)
        {
            if (item.Text.Length == 0)
            {
                add.Enabled = false;
            }

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
            bool work = true;
            copyItem = copyItem.Trim();
            
                while (work)
                {
                    copyItem = copyItem.Replace("  ", " ");

                    if (copyItem.IndexOf("  ") == -1)
                    {
                        work = false;
                    }


                   
                }
            
            copyItem = null;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            item.Text = item.Text.Trim();

            shoppingList.Items.Add(item.Text);
            add.Enabled = false;
            item.Text = null;
            
        }

        private void shoppingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete.Enabled = true;
        }


        private void gh_Load(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            shoppingList.Items.RemoveAt(shoppingList.SelectedIndex);
            delete.Enabled = false;
        }
    }
}
