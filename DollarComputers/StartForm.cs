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
        public StartForm()
        {
            InitializeComponent();
        }

        private void _StartFormButtonClickHandler(Object sender, EventArgs e)
        {
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

                    break;
                case "exit":

                    break;
            }
        }
    }
}
