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
    // Order form class
    public partial class OrderForm : Form
    {

        // refernce to the previous ProductInfoForm
        public ProductInfoForm productInfoForm;

        /// <summary>
        /// Order Form Constructor
        /// </summary>
        /// <param name="productDetails">Collection of details about the product for which the order is to be placed</param>
        public OrderForm(Dictionary<string, string> productDetails)
        {
            InitializeComponent();
            // fill the form with data received
            this._fillForm(productDetails);
        }

        // Method to fill the values in the form
        private void _fillForm(Dictionary<string, string> productDetails)
        {

            // fill the SystemComponentsGroupBox
            foreach (TextBox textBox in this.SystemComponentsGroupBox.Controls.OfType<TextBox>())
            {
                textBox.Text = productDetails[textBox.Tag.ToString()];
            }

            // fill the ProductsDetailsGroupBox
            foreach (Label currentLabel in this.ProductsDetailsGroupBox.Controls.OfType<Label>())
            {
                // tag value of each label represent the key of the productsDetails collection
                ProductsDetailsListBox.Items.Add(productDetails[currentLabel.Tag.ToString()]);
                ProductsDetailsListBox.Items.Add(""); // blank element for formatting (display purposes)
            }

            // fill the PriceInfoGroupBox
            this.PriceTextBox.Text = "$" + productDetails["cost"];
            this.SalesTaxTextBox.Text = "$" + (Double.Parse(productDetails["cost"]) * 0.13).ToString();
            this.TotalPriceTextBox.Text = "$" + (Double.Parse(productDetails["cost"]) * 1.13).ToString();

            // Set the image depending on the product manufacturer
            switch (productDetails["manufacturer"])
            {
                case "lenovo":
                    LaptopPictureBox.BackgroundImage = DollarComputers.Properties.Resources.lenovo;
                    break;
                case "hp":
                    LaptopPictureBox.BackgroundImage = DollarComputers.Properties.Resources.hp;
                    break;
                case "acer":
                    LaptopPictureBox.BackgroundImage = DollarComputers.Properties.Resources.acer;
                    break;
                case "asus":
                    LaptopPictureBox.BackgroundImage = DollarComputers.Properties.Resources.asus;
                    break;
                default:
                    LaptopPictureBox.BackgroundImage = DollarComputers.Properties.Resources.demo_thinkpad;
                    break;
            }
        }
        

        // Shared click Event handler for buttons and menu items
        private void _OrderFormButtonClickEventHandler(Object sender, EventArgs e)
        {
            
            // declaring a Button object
            Button buttonClicked = null;
            ToolStripMenuItem menuItemClicked = null;

            try
            {
                // casting the sender object into Button
                buttonClicked = sender as Button;

                // if it wasn't clicked by Button, buttonClicked will be null
                if (buttonClicked == null)
                {
                    throw new Exception(); // throw exception so as to cast the sender to menu item now
                }
            }
            catch (Exception ex)
            {
                // casting the sender object into a ToolStripMenuItem
                menuItemClicked = sender as ToolStripMenuItem;
            }

            // perform action based on tag identification
            switch ((buttonClicked != null) ? buttonClicked.Tag.ToString() : menuItemClicked.Tag.ToString())
            {
                case "cancel":
                case "exit":
                    // exit the application

                    // confirm the closure
                    DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    break;

                case "finish":
                    // Display the message of order sucess
                    MessageBox.Show("Thanks for placing your order with us!" + Environment.NewLine + "Your order will be processed in 7-10 business days.", "Order placed");
                    // exit the application
                    Application.Exit();
                    break;

                case "back":
                    // Show the previous ProductInfoForm
                    productInfoForm.Show();

                    // Close this form (no longer required)
                    this.Close();
                    break;

                case "about":
                    // Create an instance of the About Box
                    AboutBox aboutBox = new AboutBox();
                    // Display the modal About Box
                    aboutBox.ShowDialog();
                    break;

                case "print":
                    // message to inform users the order info being printed
                    MessageBox.Show("Your order information for " + this.ManufacturerTextBox.Text + " " + this.ModelTextBox.Text + " is being printed.", "Print Confirmation");
                    break;
            }
        }
    }
}
