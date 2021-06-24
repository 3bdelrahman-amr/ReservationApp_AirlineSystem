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
    public partial class FlightCrew : Form
    {
        Controller control;
        int userid;
        public FlightCrew(int q)
        {
            userid = q;
            InitializeComponent();
            control = new Controller();
            DataTable dt = control.SelectClient();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ClientID";
            comboBox1.ValueMember = "ClientID";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = control.SelectFlightInfo(userid);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Please choose a status");
            }
            else
            {
                int k = control.UpdateClient(comboBox2.Text, Convert.ToInt32(comboBox1.Text));
                if (k == 0)
                    MessageBox.Show("Updating failed");
                else
                    MessageBox.Show("Updated Successfully");
            }
        }
    }
}
