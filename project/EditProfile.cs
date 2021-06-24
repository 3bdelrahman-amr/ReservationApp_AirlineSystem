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
    public partial class EditProfile : Form
    {
        Controller c;
        int c_id;
        public EditProfile(int id)
        {
            InitializeComponent();
            c = new Controller();
            c_id = id;
            tt1.Text = c_id.ToString();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            if (!(st2.Text.Equals("") || np.Text.Equals(""))) //change pass only
            {
                int result = c.changePass(c_id, np.Text, st2.Text);
                if (result == 0)
                {
                    MessageBox.Show("The Update of a new Client failed");
                }
                else
                {
                    MessageBox.Show("You're Password updated successfully!");
                }
            }
            else
            {
                MessageBox.Show("Fill in Old Pass and New Pass!");
            }
        }
            
           
         

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(st3.Text.Equals("") || st4.Text.Equals(""))) //change fname,lname
            {
                int result = c.changeName(c_id, st3.Text, st4.Text);
                if (result == 0)
                {
                    MessageBox.Show("The Update of a new Client failed");
                }
                else
                {
                    MessageBox.Show("You're Name updated successfully!");
                }
            }
            else
            {
                MessageBox.Show("Fill in Fname and Lname!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(st5.Text.Equals(""))) //change fname,lname
            {
                int result = c.changeAdd(c_id, st5.Text);
                if (result == 0)
                {
                    MessageBox.Show("The Update of a new Client failed");
                }
                else
                {
                    MessageBox.Show("You're Address updated successfully!");
                }
            }
            else
            {
                MessageBox.Show("Fill in The address field!");
            }
        }
    }
}
