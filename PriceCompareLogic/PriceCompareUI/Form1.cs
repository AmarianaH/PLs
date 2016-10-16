using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PriceCompareFramework.Manager;

namespace PriceCompareUI
{
    public partial class Form1 : Form
    {
        public Controller Controller;
        public Form1(Controller controller)
        {
            Controller = controller;
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            //AddingToCart atc = new AddingToCart(Controller);

        }

        private void addingToCart1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void choosingQuantity1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addingToCart1_Load_1(object sender, EventArgs e)
        {

        }

        private void choosingQuantity1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
