using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PriceCompareFramework.Handlers;
using PriceCompareFramework.Manager;
using PriceCompareUI.Components;

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
    public partial class CartPriceForAllStoresForm : Form
    {
        public static Store SelectedStore; 
        public Controller Controller;
        public CartPriceForAllStoresForm(Controller controller)
        {
            Controller = controller; 
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (var store in Controller.GetAllStoresList())
            {
                if(! comboBox1.Items.Contains(store.StoreName))
                    comboBox1.Items.Add(store.StoreName);
                
            }

            if(comboBox1.SelectedItem==null)
                comboBox1.SelectedItem = comboBox1.Items[0];

            foreach (var store in Controller.GetAllStoresList())
            {
                if (store.StoreName.Equals(comboBox1.SelectedItem.ToString()))
                {
                    SelectedStore = store;
                }
            }
        }

        private void CartPriceForAllStoresForm_Load(object sender, EventArgs e)
        {
            
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void viewListPerStore1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewListPerStore1_Load(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
