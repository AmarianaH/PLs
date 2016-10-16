using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PriceCompareFramework.Manager;
using static PriceCompareUI.Program;

namespace PriceCompareUI
{
    public partial class ChoosingQuantity : UserControl
    {
        public Controller Controller;

        public ChoosingQuantity(Controller controller)
        {
            Controller = controller;
            InitializeComponent();
        }


        public ChoosingQuantity()
        {
            InitializeComponent();
        }


        private void ChoosingQuantity_Load(object sender, EventArgs e)
        {
          
            
        }

      

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void ViewTheCartList_Click(object sender, EventArgs e)
        {
            checkedListBox1.RightToLeft = RightToLeft.Yes;
            checkedListBox1.Items.Clear();
            foreach (var item in ItemsToBuy)
            {
                if (!checkedListBox1.Items.Contains(item.ItemName))
                {
                    checkedListBox1.Items.Add(item.ItemName);
                }
                
            }

        }

       
        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            CalculatingPriceForm a = new CalculatingPriceForm(Controller);
            a.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowCart s = new ShowCart();
            s.Show();
        }
    }
}
