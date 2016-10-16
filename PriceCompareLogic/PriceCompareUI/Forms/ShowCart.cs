using PriceCompareUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCompareUI
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
    public partial class ShowCart : Form
    {
        public ShowCart()
        {
            InitializeComponent();
        }

        private void ShowCart_Load(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StoresForm s = new StoresForm();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CalculatingPriceForm.ItemsAndQuantity == null)
            {
                CalculatingPriceForm cp = new CalculatingPriceForm(Program._controller);
                cp.SaveDataBeforeExit();
            }
            CartPriceForAllStoresForm c = new CartPriceForAllStoresForm(Program._controller);
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostExpensive mostExp = new MostExpensive();
            mostExp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphs g = new Graphs();
            g.Show();
        }
    }
}
