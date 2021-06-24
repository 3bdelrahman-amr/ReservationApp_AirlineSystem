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
    public partial class Employee : Form
    {
        Controller controllerObj;
        public Employee()
        {
            controllerObj = new Controller();
            InitializeComponent();
            comboBox1.DataSource = controllerObj.GetAllClients();
            comboBox1.Refresh();
            comboBox2.DataSource = controllerObj.GetAllFlights();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {

            DataTable dt = controllerObj.SelectAvailableFlights();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

       
       

       

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "A" && textBox10.Text != "a" && textBox10.Text != "B" && textBox10.Text != "b" && textBox10.Text != "C" && textBox10.Text != "c")
            {
                MessageBox.Show("Please, insert A or a or B or b or C or c");
            }

            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("choose the client ID and the flight number and the class");
            }
            else {
                string a = comboBox1.Text;
                int cidd = Convert.ToInt32(a);
                
                string c = comboBox2.Text;
                int fnom = Convert.ToInt32(c);
                int r = controllerObj.InsertinBook(cidd, fnom, textBox10.Text);

                if (r == 1)
                    MessageBox.Show("Client is added to the flight successfully");
                else
                    MessageBox.Show("Client isnot added to the flight successfully");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if (comboBox1.Text == "" )
            //{
            //    MessageBox.Show("choose the client ID ");
            //}
            //else
            //{
            //    string a = comboBox1.Text;
            //    int cidd = Convert.ToInt32(a);

               
            //    int r = controllerObj.RemoveClient(cidd);

            //    if (r == 1)
            //        MessageBox.Show("Client is removed from the flight successfully");
            //    else
            //        MessageBox.Show("Client isnot removed from the flight successfully");

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("choose the client ID ");
            }
            else
            {
                string a = comboBox1.Text;
                int cidd = Convert.ToInt32(a);

                string c = comboBox2.Text;
                int fnom = Convert.ToInt32(c);

                int r = controllerObj.RemoveClient(cidd,fnom);

                if (r == 1)
                    MessageBox.Show("Client is removed from the flight successfully");
                else
                    MessageBox.Show("Client is not removed from the flight successfully");

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}