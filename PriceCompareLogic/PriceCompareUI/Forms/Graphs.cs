using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PriceCompareFramework.Handlers;
using static PriceCompareUI.Program;

namespace PriceCompareUI.Forms
{
    /**
  * When creating a UI application- consider one of the following paradigms: MVC, MVP or MVVM
  * It is best to refrain from coding in the codebehind of the UI class.
  * This enables better testability and separation of UI from User interaction, Business Logic and Data Access.
  * 
  * Consider :
  * a) https://he.wikipedia.org/wiki/Model_View_Controller
  * b) https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93presenter
  * c) https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93viewmodel
  */
    public partial class Graphs : Form
    {
        public List<Store> ChoosenChain;

        public Graphs()
        {
            ChoosenChain = new List<Store>();
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }
        
        private double price(Store ChoosenStore)
        {
            double price;
            var quantity = CalculatingPriceForm.ItemsAndQuantity;
            if (ChoosenStore == null || CalculatingPriceForm.ItemsAndQuantity == null)
            {
                MessageBox.Show("תגדיר כמות לפני שלב זה",
                    "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
            price = _controller.CalculateItemsPriceInOneStore(ChoosenStore,
                CalculatingPriceForm.ItemsAndQuantity.Keys);

            foreach (var item in quantity.Values)
            {
                if (item.Item2 != 1)
                {
                    price =_controller.CalculateItemsPriceInOneStoreWithQuantity(
                            ChoosenStore, CalculatingPriceForm.ItemsAndQuantity);
                }
            }
            return price;

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Graphs_Load(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count < 2)
            {
                comboBox1.Items.Add("TivTaam");
                comboBox1.Items.Add("DorAlon");
                comboBox1.Items.Add("OsherAd");
            }


            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chainId = "";
            ChoosenChain.Clear();
            if (comboBox1.SelectedItem == null) comboBox1.SelectedItem = comboBox1.Items[0];
            if (comboBox1.SelectedItem.Equals("TivTaam")) chainId = "7290873255550";
            if (comboBox1.SelectedItem.Equals("DorAlon")) chainId = "7290492000005";
            if (comboBox1.SelectedItem.Equals("OsherAd")) chainId = "7290103152017";
            {
                foreach (var store in _controller.GetAllStoresList())
                {
                    if (chainId.Equals(store.ChainId))
                        ChoosenChain.Add(store);
                }
            }
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            foreach (var store in ChoosenChain)
            {
                listBox1.Items.Add(store.StoreName);
                listBox2.Items.Add(price(store));
            }
        }
    }
}