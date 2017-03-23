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
        private Dictionary<string, string> _ProductData;

        // SelectForm reference
        public SelectForm selectForm;

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
                this._ProductData = selectedProduct;
            }
            else
            {
                // if no selected product was transferred, i.e., product to be selected from saved orders
                this.openToolStripMenuItem.PerformClick(); // initamtest the click on Open button in the menu and runs the required logic
            }

            // call the fill method to fill the form data
            _fillProductInfo();
        }

        // Click Event handler for buttons
        private void _ProductInfoFormButtonClickEventHandler(Object sender, EventArgs e)
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
                    // create an instance of the OrderForm
                    OrderForm orderForm = new OrderForm(this._ProductData);

                    // pass the reference of this form
                    orderForm.productInfoForm = this;

                    // hide the ProductInfoForm
                    this.Hide();

                    // show the OrderForm
                    orderForm.Show();

                    break;
            }
        }

        // Shared click event handler for Select Another product
        private void _SelectAnotherProduct(Object sender, EventArgs e)
        {
            // if the SelectForm's reference has been defined, i.e., the ProductInfoForm was generated from the SelectForm
            if (selectForm != null)
            {
                // show the previously hidden selectForm
                selectForm.Show();

                // Close this ProductInfoForm, since a new ProductInfoForm will be generated through the SelectForm
                this.Close();
            }
            else
            {
                // else is selectForm == null; therefore the ProductInfoForm was created directly from the StartForm
                // instantiate a new instance of the SelectForm
                selectForm = new SelectForm();

                // show the new select form
                selectForm.Show();

                // Close this ProductInfoForm, since a new ProductInfoForm will be generated through the SelectForm
                this.Close();
            }
        }

        // fill the form text boxes
        private void _fillProductInfo()
        {
            // fill the product id, condition, cost (independent items outside any GroupBox)
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Text = this._ProductData[textBox.Tag.ToString()];

            }

            // fill the ProductInfoGroupBox
            foreach (TextBox textBox in this.ProductInfoGroupBox.Controls.OfType<TextBox>())
            {
                textBox.Text = this._ProductData[textBox.Tag.ToString()];
            }

            // fill the TechSpecsGroupBox
            foreach (TextBox textBox in this.TechSpecsGroupBox.Controls.OfType<TextBox>())
            {
                textBox.Text = this._ProductData[textBox.Tag.ToString()];
            }
        }

        // read the file
        private void _readProductFile(Object sender, EventArgs e)
        {
            // Open the OpenProductFileDialog Box
            this.OpenProductFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult result = this.OpenProductFileDialog.ShowDialog();


            if (result == DialogResult.OK)
            {
                // Declare the StreamReader Object
                StreamReader fileStreamReader = null;

                // if user has selected a file then try to open and read it
                try
                {
                    // Open the read stream
                    fileStreamReader = new StreamReader(this.OpenProductFileDialog.FileName);

                    // instantiate or clear the _ProductData before entering new data
                    this._ProductData = new Dictionary<string, string>();

                    // while there is data in file to be read
                    while (fileStreamReader.Peek() != -1)
                    {
                        string[] dataRead = fileStreamReader.ReadLine().Split(':');
                        // read each line and insert the data to the _ProductData collection
                        this._ProductData.Add(dataRead[0], dataRead[1]);
                    }

                    // fill the data on the ProductInfoForm
                    this._fillProductInfo();
                }
                catch (Exception ex)
                {
                    // Give an appropriate error message
                    MessageBox.Show("Error reading the file. Please try again!", "Error Reading File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine(ex); // write the essential error information to the console
                }
                finally
                {
                    if (fileStreamReader != null)
                    {
                        // Close the stream and release the resources
                        fileStreamReader.Close();
                    }
                }
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
                // Declare the StreamWriter Object
                StreamWriter fileStreamWriter = null;

                try
                {
                    // Open the file stream for writing
                    fileStreamWriter = new StreamWriter(this.SaveProductFileDialog.FileName);

                    // loop through each element inside the _ProductData collection to write it to the file
                    foreach (KeyValuePair<string, string> productDetail in this._ProductData)
                    {
                        // write the product detail into file. Example: "productID 7"
                        fileStreamWriter.WriteLine(productDetail.Key + ":" + productDetail.Value);
                    }
                }
                catch (Exception ex)
                {
                    // Give an error message
                    MessageBox.Show("Error saving the file. Please try again!", "Error Saving File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine(ex); // print required error information to the console
                }
                finally
                {
                    if (fileStreamWriter != null)
                    {
                        // Close the stream and release the resources
                        fileStreamWriter.Close();
                    }
                }
            }
        }

        // Exit menu option click event handler
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // uses the same logic as cancel button to exit the application
            this.CancelButton.PerformClick();
        }
    }
}
