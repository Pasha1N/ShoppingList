namespace ShoppingList
{
    partial class windowShoppingList
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.shoppingList = new System.Windows.Forms.CheckedListBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.item = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // shoppingList
            // 
            this.shoppingList.FormattingEnabled = true;
            this.shoppingList.Location = new System.Drawing.Point(12, 12);
            this.shoppingList.Name = "shoppingList";
            this.shoppingList.Size = new System.Drawing.Size(343, 349);
            this.shoppingList.TabIndex = 0;
            this.shoppingList.SelectedIndexChanged += new System.EventHandler(this.shoppingList_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.add.Enabled = false;
            this.add.Location = new System.Drawing.Point(280, 402);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 20);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Enabled = false;
            this.delete.Location = new System.Drawing.Point(12, 431);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(346, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // item
            // 
            this.item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item.Location = new System.Drawing.Point(12, 402);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(262, 20);
            this.item.TabIndex = 3;
            this.item.Text = "  ";
            this.item.TextChanged += new System.EventHandler(this.item_TextChanged);
            // 
            // windowShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 482);
            this.Controls.Add(this.item);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.shoppingList);
            this.Name = "windowShoppingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping List";
            this.Load += new System.EventHandler(this.gh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox shoppingList;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox item;
    }
}

