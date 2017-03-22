using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class ProductInfoForm : Form
    {

        // stores the product data

        /// <summary>
        /// ProductInfoForm constructor
        /// </summary>
        /// <param name="selectedProduct">Dictonary objact containing information of product selected</param>
        public ProductInfoForm(Dictionary<string, string> selectedProduct)
        {
            InitializeComponent();

            // if selectedProduct has been receievd
            if (selectedProduct != null)
            {
                // pass the product info received to the fill method
                _fillProductInfo(selectedProduct);
            }
            else
            {
                // if no selected product was transferred, i.e., product to be selected from saved orders
                Debug.WriteLine("Product not recieved");
            }
            
        }

        // fill the form text boxes
        private void _fillProductInfo(Dictionary<string, string> productInfo)
        {
            // fill the product id, condition, cost (independent items outside any GroupBox)
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Text = productInfo[textBox.Tag.ToString()];

            }

            // fill the ProductInfoGroupBox
            foreach (TextBox textBox in this.ProductInfoGroupBox.Controls.OfType<TextBox>())
            {
                textBox.Text = productInfo[textBox.Tag.ToString()];
            }

            // fill the TechSpecsGroupBox
            foreach (TextBox textBox in this.TechSpecsGroupBox.Controls.OfType<TextBox>())
            {
                textBox.Text = productInfo[textBox.Tag.ToString()];
            }
        }

        // read the file
        private void _readProductFile(Object sender, EventArgs e)
        {
            // Open the OpenProductFileDialog Box
            this.OpenProductFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult result = this.OpenProductFileDialog.ShowDialog();

            // if user doesn't select a file
            if (result == DialogResult.Cancel)
            {
                // no file will be read since user cancelled the request to read a file
                return;
            }

            // if user has selected a file then try to open and read it
            try
            {
                // Open the read stream
                StreamReader fileStreamReader = new StreamReader(this.OpenProductFileDialog.FileName);

                // dictionary to store the product data being read
                Dictionary<string, string> productData = new Dictionary<string, string>();

                // while there is data in file to be read
                while (fileStreamReader.Peek() != -1) 
                {
                    productData.Add(fileStreamReader.ReadLine().Split(' ')[0], fileStreamReader.ReadLine().Split(' ')[1]);
                }

                // transfer the data to be filled on the ProductInfoForm
                this._fillProductInfo(productData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading the file. Please try again!", "Error Reading File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex);
            }
        }

        // save to the file
        private void _saveProductFile(Object sender, EventArgs e)
        {
            // open the save file dialog box
            this.SaveProductFileDialog.InitialDirectory = Directory.GetCurrentDirectory();  // set the intial directory
            DialogResult result = SaveProductFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    // Open the file stream for writing
                    StreamWriter fileStreamWriter = new StreamWriter(this.SaveProductFileDialog.FileName);


                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }
     }
}
