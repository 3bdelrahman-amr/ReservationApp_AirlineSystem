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
    public partial class VClients : Form
    {
        Controller c;
        public VClients()
        {
            c = new Controller();
            InitializeComponent();
            dataGridView1.DataSource = c.GetAllClients();
            dataGridView1.Refresh();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.GetAllClients();
            dataGridView1.Refresh();

        }
    }
}
