using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PriceCompareFramework.Manager;
using static PriceCompareUI.Program;

namespace PriceCompareUI
{
    public partial class AddingToCart : UserControl
    {
        public static Controller Controller; 
        public AddingToCart(Controller _controller)
        {
            Controller = _controller;
            InitializeComponent();
        }
        public AddingToCart()
        {
            Controller = _controller;
            InitializeComponent();
        }

        private void AddingToCart_Load(object sender, EventArgs e)
        {
            checkedListBox2.RightToLeft = RightToLeft.Yes;
            checkedListBox1.RightToLeft = RightToLeft.Yes; 
            checkedListBox1_SelectedIndexChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var checkedItem in checkedListBox1.CheckedItems)
                if (!checkedListBox2.Items.Contains(checkedItem))
                    checkedListBox2.Items.Add(checkedItem);
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                var ch = checkedListBox1.Items[i];
                checkedListBox1.SetItemChecked(checkedListBox1.Items.IndexOf(ch), false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = checkedListBox2.CheckedItems;
            while (a.Count > 0)
            {
                for (int index = 0; index < a.Count; index++)
                {
                    var checkedItem = a[index];
                    checkedListBox2.Items.Remove(checkedItem);
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ourItems = Controller.GetItemsWithoutDuplicates().ToList();
            if (checkedListBox1.Items.Count < ourItems.Count())
                
                foreach (var item in ourItems)
                    checkedListBox1.Items.Add(item.ItemName);
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var iWithoutDup = Controller.GetItemsWithoutDuplicates();
            var iInCart = checkedListBox2.Items;
            ItemsToBuy.Clear();
            foreach (var item in iWithoutDup)
                foreach (var i in iInCart)
                    if (item.ItemName.Equals(i.ToString()))
                        ItemsToBuy.Add(item);
        }
    }
}