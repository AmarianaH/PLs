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
    public partial class Cart : Form
    {
        public Store SelectedStore;
        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var store in _controller.GetAllStoresList())
                if (!comboBox1.Items.Contains(store.StoreName))
                    comboBox1.Items.Add(store.StoreName);

            if (comboBox1.SelectedItem == null)
                comboBox1.SelectedItem = comboBox1.Items[0];

            foreach (var store in _controller.GetAllStoresList())
                if (store.StoreName.Equals(comboBox1.SelectedItem.ToString()))
                    SelectedStore = store;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1_SelectedIndexChanged_1(sender, e);
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1)
                foreach (var item in Program._controller.GetTheCheapest3ItemsInStore(SelectedStore))
                    listBox1.Items.Add($"{item.ItemName} - {item.ItemPrice}");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {}
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
