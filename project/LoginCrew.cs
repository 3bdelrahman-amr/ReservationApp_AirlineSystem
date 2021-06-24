using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class LoginCrew : Form
    {
        Controller control;
        public LoginCrew()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            control = new Controller();
            if (textBox2.Text == control.findpass(Convert.ToInt32(textBox1.Text)))
            {
                    //Login successful
                   FlightCrew f = new FlightCrew(Convert.ToInt32(textBox1.Text));
                   f.Show();
            }
            else
            {
                MessageBox.Show("Password isn't correct, Please Try Again");
            }
        }

        private void LoginCrew_Load(object sender, EventArgs e)
        {

        }
    }
}
