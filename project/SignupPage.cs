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
    public partial class SignupPage : Form
    {
        Controller c;
        public SignupPage()
        {
            InitializeComponent();
            c = new Controller();
        }

        private void SignupPage_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void signupbutton_Click(object sender, EventArgs e)
        {

            if (st1.Text.Equals("")||st2.Text.Equals("") || st3.Text.Equals("") || st4.Text.Equals("") || st6.Text.Equals("") || st7.Text.Equals("") || st8.Text.Equals(""))
            {
                MessageBox.Show("Please Add all The Fields");
                return;
            }
            else
            {
                int result = c.InsertClient(st1.Text,st2.Text, st3.Text, st4.Text, st6.Text, st7.Text, st8.Text);
                if (result == 0)
                {
                    MessageBox.Show("The insertion of a new Client failed");
                }
                else
                {
                    MessageBox.Show("You're signed up successfully!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = c.viewCliendID(st1.Text,st2.Text);
            grid.DataSource = dt;
            grid.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginClient l = new LoginClient();
            l.Show();
        }
    }
}
