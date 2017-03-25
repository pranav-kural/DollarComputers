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
    public partial class SplashForm : Form
    {

        // SplashForm constructor
        public SplashForm()
        {
            InitializeComponent();
        }

        private void _SplashFormTimer_Tick(object sender, EventArgs e)
        {
            // create a new instance of StartForm
            StartForm startForm = new StartForm();

            // disable the timer
            SplashFormTimer.Enabled = false;

            // Hide the splash form
            this.Hide();

            // Show the start form
            startForm.Show();
        }
    }
}
