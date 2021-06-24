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
    public partial class AddAirPortF : Form
    {
        Controller CObj; Validate val;
        public AddAirPortF()
        {
            CObj = new Controller();
            val = new Validate();
            InitializeComponent();
        }

        private void AddAirPort_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (val.isinteger(ACode.Text, ref s)|| val.isinteger(NoOfPlanes.Text, ref s)|| LCountry.Text==""
                || AName.Text=="")//validation 
            {
                MessageBox.Show("insertian failed!incorrect type(s)");
                return;
            }

            int code=int.Parse(ACode.Text);
            int NoOfPlane = int.Parse(NoOfPlanes.Text);
            string country = LCountry.Text;
            string PortName = AName.Text;
           int result= CObj.InsertAirport(code, NoOfPlane, country, PortName);
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
