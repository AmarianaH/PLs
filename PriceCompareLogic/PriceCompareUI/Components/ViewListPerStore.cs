using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PriceCompareFramework.Manager;
using PriceCompareUI.Forms;

namespace PriceCompareUI.Components
{
    public partial class ViewListPerStore : UserControl
    {
        public ViewListPerStore()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ss = CalculatingPriceForm.ItemsAndQuantity;
            if (listBox1.Items.Count < 1)
            {
                foreach (var i in ss)
                {
                    
                    listBox1.Items.Add(i.Value.Item2);
                }
               
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var ss = CalculatingPriceForm.ItemsAndQuantity;
            if (listBox2.Items.Count < 1)
            {
                foreach (var i in ss)
                {
                    listBox2.Items.Add(i.Value.Item1);
                }
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox3.Items.Clear();
            var store = CartPriceForAllStoresForm.SelectedStore;
            var ss = CalculatingPriceForm.ItemsAndQuantity;
            if (store!=null)
            {
                foreach (var i in ss)
                {
                    var a = Program._controller.GetThisItemInThisStore(store, i.Key);
                    listBox3.Items.Add(a.ItemPrice);
                }
            }


        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double price;
            textBox2.RightToLeft = RightToLeft.Yes;
            var quantity = CalculatingPriceForm.ItemsAndQuantity;
            price = Program._controller.CalculateItemsPriceInOneStore(CartPriceForAllStoresForm.SelectedStore, CalculatingPriceForm.ItemsAndQuantity.Keys);

            foreach (var item in quantity.Values)
            {
                if (item.Item2 != 1)
                {
                    price =
                        Program._controller.CalculateItemsPriceInOneStoreWithQuantity(
                            CartPriceForAllStoresForm.SelectedStore, CalculatingPriceForm.ItemsAndQuantity);
                }
            }



            textBox2.Text = price + " ש\"ח ";

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewListPerStore_Load(object sender, EventArgs e)
        {
            listBox3_SelectedIndexChanged(sender, e);
            listBox1_SelectedIndexChanged(sender, e);
            listBox2_SelectedIndexChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox3_SelectedIndexChanged(sender, e);
            textBox2_TextChanged(sender, e);
        }
    }
}
