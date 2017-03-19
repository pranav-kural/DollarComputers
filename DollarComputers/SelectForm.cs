using DollarComputers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class SelectForm : Form
    {
        // connecting to the Products Models
        ProductsModel DollarComputersDB = new ProductsModel();

        public SelectForm()
        {
            InitializeComponent();
        }

        // Click Event handler for buttons
        private void SelectFormButtonClickEventHandler(Object sender, EventArgs e)
        {
            // casting the sender object into Button
            Button buttonClicked = sender as Button;

            switch (buttonClicked.Tag.ToString())
            {
                case "cancel":
                    // exit the application

                    // confirm the closure
                    DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }

                    break;
                case "next":

                    break;
            }
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // select all the products in the Products table of the DollarComputers DB
            var ProductList = (from product in DollarComputersDB.products
                               select product).ToList();

            // bind the ProductList to the ProductsDataGridView
            ProductsDataGridView.DataSource = ProductList;
        }

        private void ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ProductsDataGridView.Rows[ProductsDataGridView.CurrentRow.Index].Selected = true;
                NextButton.Enabled = true; // enable the next button on selection being made
            }
            catch (Exception ex)
            {
                // empty catch block to catch the NullPointerException thrown when the form is
                // first loaded without any prior selection
            }
        }
    }
}
