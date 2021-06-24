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
    public partial class AddPlaneF : Form
    {
        Controller CObj; Validate val;
        public AddPlaneF()
        {
            InitializeComponent();
            CObj = new Controller();
            val = new Validate();
            StatusBox.Items.Add("Working");
            StatusBox.Items.Add("Need To Be Fixed");
        }

        private void StatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void CapacityTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPlaneBtn_Click(object sender, EventArgs e)
        {
            int s=0, c=0;
            if (val.isinteger(SNumberTxt.Text, ref s) || val.isinteger(ECap.Text, ref s)|| ECap.Text==""|| ModelTxt.Text==""
                || StatusBox.SelectedItem.ToString()==""|| val.isinteger(FCap.Text, ref s) || FCap.Text == "")//validation of user input
            {
                MessageBox.Show("insertian failed!incorrect type(s)");
                return;
            }

            int serial = int.Parse(SNumberTxt.Text);
            string Status = StatusBox.SelectedItem.ToString();
            string Model = ModelTxt.Text;
            int ECapacity = int.Parse(ECap.Text);
            int FCapacity = int.Parse(FCap.Text);

            int result= CObj.InsertPlane(serial,Status,Model,ECapacity,FCapacity);
            if (result == 0)
            {
                MessageBox.Show("The insertion is failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully");
            }

        }
    }
}
