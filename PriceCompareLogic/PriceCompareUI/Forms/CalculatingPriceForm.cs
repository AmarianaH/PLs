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
using static PriceCompareUI.Program;

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
    public partial class CalculatingPriceForm : Form
    {

        public static Dictionary<Item, Tuple<string, decimal>> ItemsAndQuantity;
        private Controller Controller;

        public CalculatingPriceForm(Controller controller)
        {
            Controller = controller;

            ItemsAndQuantity = new Dictionary<Item, Tuple<string, decimal>>();
            InitializeComponent();
        }

        private void CalculatingPriceForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            foreach (var item in ItemsToBuy)
            {
                comboBox1.Items.Add(item.ItemName);
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = null;
            foreach (var realItem in ItemsToBuy)
            {
                if (comboBox1.SelectedItem.ToString().Equals(realItem.ItemName))
                    item = realItem;
            }
            if (ItemsAndQuantity.ContainsKey(item))
            {
                Tuple<string, decimal> tup;
                ItemsAndQuantity.TryGetValue(item, out tup);
                if (tup != null) numericUpDown1.Value = tup.Item2;
            }
            else
            {
                numericUpDown1.Value = 1;
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("אנא בחר בפריט לפני שמירה",
                    "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                return;
            }

            var itemName = comboBox1.SelectedItem.ToString();
            var quantity = numericUpDown1.Value;
            Item item = null;

            foreach (var realItem in ItemsToBuy)
            {
                if (itemName.Equals(realItem.ItemName))
                    item = realItem;
            }
            var tup = new Tuple<string, decimal>(itemName, quantity);
            if (item != null && tup != null)
                if (!ItemsAndQuantity.ContainsKey(item))
                    ItemsAndQuantity.Add(item, tup);

            MessageBox.Show($" המוצר : {itemName} \n נשמר בכמות : {quantity} ",
                "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);
            numericUpDown1.Value = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var click = MessageBox.Show("אתה בטוח שרוצה לסגור",
                "", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);
            if (click == DialogResult.Yes)
            {
                SaveDataBeforeExit();
                this.Close();

            }

        }

        public void SaveDataBeforeExit()
        {
            if (ItemsToBuy == null) return;
            foreach (var item in ItemsToBuy)
            {
                if (!ItemsAndQuantity.ContainsKey(item))
                {
                    var tup = new Tuple<string, decimal>(item.ItemName, 1);
                    ItemsAndQuantity.Add(item, tup);
                }
            }
        }

    }
}
