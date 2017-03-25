using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///<summary>
/// Georgian College - Computer Programmer
/// COMP 1004 - Rapid Application Development
/// Instructor: Tom Tsiliopoulos
/// 
/// Assignment 4: Dollar Computers: A project that simulates the purchase of a
/// computer. It initially gives the user options between starting a new order
/// or loading a saved order from a file. The user then can select the hardware,
/// or select a configuration file containing information about the hardware. They
/// can also save the current order configuration to a new file. Once the user proceeds
/// with the order he will be shown the information of the order with price information,
/// and the order will be finalised on user pressing the Finish button.
/// 
/// BONUS: Used the Entity Framework.
/// 
/// Author Name: Pranav Kural
/// Student Number: 200333253
/// 
/// Brief revision history:
/// Initial commit to add default .gitIgnore and .gitAttribute files.
/// .....
/// Added the AboutBox information
/// Picture Box functionality for the Order Form
/// Added Documentaion and commenting to the code
/// </summary>

namespace DollarComputers
{
    public partial class StartForm : Form
    {

        // StartForm constructor
        public StartForm()
        {
            InitializeComponent();
        }

        // Click event handler for the buttons on the StartForm
        private void _StartFormButtonClickHandler(Object sender, EventArgs e)
        {
            // cast the sender object to type Button
            Button buttonClicked = sender as Button;

            switch (buttonClicked.Tag.ToString())
            {
                case "new order":
                    // create an instance of the SelectForm
                    SelectForm selectForm = new SelectForm();

                    // hide the StartForm
                    this.Hide();

                    // show the SelectForm
                    selectForm.Show();

                    break;
                case "saved order":
                    // create an instance of the ProductInfoForm
                    ProductInfoForm productInfoForm = new ProductInfoForm(null);

                    // hide the StartForm
                    this.Hide();

                    // show the ProductInfoForm
                    productInfoForm.Show();

                    break;
                case "exit":
                    // exit the application

                    // confirm the closure
                    DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes) 
                    {
                        Application.Exit();
                    }

                    break;
            }
        }
    }
}
