using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    public partial class StoresForm : Form
    {
        public StoresForm()
        {
            InitializeComponent();
        }

        private void StoresForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PriceCompareFramework_Handlers_DatabaseTDataSet1.Stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter1.Fill(this._PriceCompareFramework_Handlers_DatabaseTDataSet1.Stores);
            // TODO: This line of code loads data into the '_PriceCompareFramework_Handlers_DatabaseTDataSet.Stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter.Fill(this._PriceCompareFramework_Handlers_DatabaseTDataSet.Stores);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
