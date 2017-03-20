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
