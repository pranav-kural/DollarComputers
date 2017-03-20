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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm(Dictionary<string, string> selectedProduct)
        {
            InitializeComponent();

            // if selectedProduct has been receievd
            if (selectedProduct != null)
            {
                Debug.WriteLine("Worked");
            }
            else
            {
                // if no selected product was transferred, i.e., product to be selected from saved orders
                Debug.WriteLine("Product not recieved");
            }
        }
    }
}
