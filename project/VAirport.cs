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
    public partial class VAirport : Form
    {
        Controller c;
        public VAirport()
        {
            c = new Controller();
            InitializeComponent();
            dataGridView1.DataSource = c.GetAllAirport();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.GetAllAirport();
            dataGridView1.Refresh();
        }
    }
}
