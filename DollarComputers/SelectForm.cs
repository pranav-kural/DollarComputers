﻿using DollarComputers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class SelectForm : Form
    {
        // connecting to the Products Models (Dollar Computers database)
        private ProductsModel _DollarComputersDB = new ProductsModel();

        // SelectForm constructor
        public SelectForm()
        {
            InitializeComponent();
        }

        // Click Event handler for buttons
        private void _SelectFormButtonClickEventHandler(Object sender, EventArgs e)
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
                    // Collection to store the selected product's properties
                    // stored with property name and value both. Example: 'productId' => '7'
                    Dictionary<string, string> selectedProduct = new Dictionary<string, string>();

                    // Get the selected cells
                    DataGridViewSelectedCellCollection selectedRow = ProductsDataGridView.SelectedCells;
                    // Add the data from selected cells to the selectedProducts Collection
                    for (int i = 0; i <= selectedRow.Count - 1; i++)
                    {
                        selectedProduct.Add(ProductsDataGridView.Columns[i].HeaderText, selectedRow[i].Value.ToString());
                    }

                    // create an instance of the ProductInfoForm
                    ProductInfoForm productInfoForm = new ProductInfoForm(selectedProduct);

                    // set the SelectForm reference for the ProductInfoForm
                    productInfoForm.selectForm = this;

                    // Hide the SelectForm
                    this.Hide();

                    // show the ProductInfoForm
                    productInfoForm.Show();
                    break;
            }
        }

        /// <summary>
        /// Load Form Even Handler - Fires when the form is loaded
        /// Connects, binds and fill in the ProductsDataGridView with the data from DollarComputerDB's products table
        /// </summary>
        /// <param name="sender">Event object received</param>
        /// <param name="e">Event arguments</param>
        private void _SelectForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Display loading form
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show(); // display loading form modelessly
                System.Windows.Forms.Application.DoEvents();

                // select all the products in the Products table of the DollarComputers DB
                var ProductList = (from product in _DollarComputersDB.products
                                   select product).ToList();

                // hide the loading form
                loadingForm.Hide();

                // bind the ProductList to the ProductsDataGridView
                ProductsDataGridView.DataSource = ProductList;

                
            }
            catch (Exception ex)
            {
                // Display an error message
                MessageBox.Show("Unable to connect to the Database. Please try again later.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // print the error information to console
                Debug.WriteLine(ex);
                // Exit the application
                //Application.Exit();
            }
            
        }

        // DataGridView SelectionChanged event handler to update selection info
        private void _ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
            try {
                // display selected product details in the Your Selection Text Box
                // SelectedCells index represents: 1 => Cost, 2 => MFG, 3=> Model
                SelectionTextBox.Text = ProductsDataGridView.SelectedCells[2].Value.ToString() + " " + ProductsDataGridView.SelectedCells[3].Value.ToString() + " Priced at: $" + ProductsDataGridView.SelectedCells[1].Value.ToString();

                NextButton.Enabled = true; // enable the next button on selection being made
            }
            catch (Exception ex)
            {
                // For any errors thrown while the DataGridView is being populated
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
