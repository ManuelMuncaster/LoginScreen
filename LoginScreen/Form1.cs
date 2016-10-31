using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{ 
    public partial class Form1 : Form
    {
        string name;
        int password; //holds the users password
        

        public Form1()
        {
            InitializeComponent();
        }

       private void label1_Click(object sender, EventArgs e)
       {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                name = nameTextbox.Text;
                password = Convert.ToInt32(passwordTextbox.Text);

                outputLabel.Text = "Welcome " + name + " Confirm your password:" + password;
            }
            catch
            {
                outputLabel.Text = "Password must be numbers only";
            }
            
        }
    }
}
