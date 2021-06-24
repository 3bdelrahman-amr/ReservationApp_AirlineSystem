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
    public partial class HomeClient : Form
    {
        Controller c;
        int client_id;
        
        public HomeClient(int id)
        {
            InitializeComponent();
            c = new Controller();
            client_id = id; //Client ID
            



        }

        private void HomeClient_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void combo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void v1_Click(object sender, EventArgs e)
        {
            DataTable result = c.viewFDetails(dest.Text, to.Text);
            gridd.DataSource = result;
            gridd.Refresh();
            


        }

        private void b1_Click(object sender, EventArgs e)
        {

            if (t11.Text.Equals("") || co1.Text.Equals("") )
            {
                MessageBox.Show("Please Choose a Flight Destination, Source, Fare before booking");
                return;
            }
            else
            { 
                object ban = c.checkBan(client_id);

                if (ban.ToString()=="False") //not banned
                {
                int result = c.BookFlight(client_id, Int32.Parse(t11.Text), co1.Text); //book the flight
                    if (result ==0 )
                    {
                    MessageBox.Show("The Booking failed due to an error in server");
                        return;
                    }
                    else
                    {
                        c.NoPass(int.Parse(t11.Text));

                        MessageBox.Show("You Booked The Trip successfully!");
                        return;
                    }
                }
                else 
               {
                    MessageBox.Show("Sorry, You can't Book this trip as you're banned!");
                    return;
                }


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void e1_Click(object sender, EventArgs e)
        {
            EditProfile d = new EditProfile(client_id);
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t11.Text.Equals("") || t22.Text.Equals("") || c1.Text.Equals("") )
            {
                MessageBox.Show("Please Flight no, Rating, Comment Fields before Send a Review");
                return;
            }
            else
            {
                int result = c.Review(Int32.Parse(t11.Text), t22.Text, Int32.Parse(c1.Text),client_id);
                if (result == 0)
                {
                    MessageBox.Show("The insertion of reviewt failed due to server");
                }
                else
                {
                    MessageBox.Show("You Review has been Added successfully!");
                }
            }
        }
    }
}
