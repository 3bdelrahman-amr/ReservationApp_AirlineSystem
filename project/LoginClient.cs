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
    public partial class LoginClient : Form
    {
        Controller c;
        public LoginClient()
        {
            InitializeComponent();
            c = new Controller();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignupPage s = new SignupPage();
            s.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t1.Text.Equals("") || t2.Text.Equals("") )
            {
                MessageBox.Show("Empty ID or Password");
                return;
            }
            else
            {
                object result = c.Login(Int32.Parse(t1.Text), t2.Text);
                if (result==null)
                {
                    MessageBox.Show("Incorrect ID or Password"); //check
                }
                else
                {
                    MessageBox.Show("You're logged in successfully!");
                    //Go to main page
                    HomeClient h = new HomeClient(Int32.Parse(t1.Text));
                    h.Show();

                }
            }
        }
    }
}
