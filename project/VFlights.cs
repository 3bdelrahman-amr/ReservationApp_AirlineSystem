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
    public partial class VFlights : Form
    {
        Controller c;
        public VFlights()
        {
            c = new Controller();
            InitializeComponent();
            dataGridView1.DataSource = c.GetAllFlights();
            dataGridView1.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.GetAllFlights();
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VAirport a = new VAirport();
             a.Show();
        }
    }
}
