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
    public partial class UpdatePlaneStatus : Form
    {
        Validate val;
        Controller CObj;
        int serial;
        public UpdatePlaneStatus()
        {
            InitializeComponent();
            CObj = new Controller();
            val = new Validate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (val.isinteger(PlaneSerial.Text, ref s) || PlaneSerial.Text == "")
                return;

             serial = int.Parse(PlaneSerial.Text);
            planeView.DataSource=CObj.SelectPlaneBySerial(serial);
            planeView.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (val.isinteger(PlaneSerial.Text, ref s) || PlaneSerial.Text == ""|| PlaneStatus.SelectedItem.ToString()=="")
                return;

            serial = int.Parse(PlaneSerial.Text);
            string status = PlaneStatus.SelectedItem.ToString();
            int result = CObj.UpdatePlaneStatus(serial, status);
            if (result == 0)
            {
               
                MessageBox.Show("The insertion is failed");
            }
            else
            {
                
                planeView.DataSource = CObj.SelectPlaneBySerial(serial);
                planeView.Refresh();
                MessageBox.Show("The row is updated successfully");
            }
        }

        
    }
}
