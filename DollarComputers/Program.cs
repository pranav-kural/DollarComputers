using System;
using System.Collections.Generic;
using System.Linq;
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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm()); // start with the Splash Form
        }
    }
}
