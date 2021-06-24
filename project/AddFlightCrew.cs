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
    public partial class AddFlightCrew : Form
    {
        Controller CObj;
        Validate val;
        public AddFlightCrew()
        {
            CObj = new Controller();
            val = new Validate();
            InitializeComponent();
        }

        private void AddEmployeeF_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Flight_CrewButton_Click(object sender, EventArgs e)
        {
            int s = 0;
            if(val.isinteger(ID.Text,ref s)||ID.Text==""||FNameTxt.Text==""||LName.Text==""||Password.Text==""
                || Role.Text==""||Address.Text=="")
            {
                MessageBox.Show("insertian failed!\nincorrect type(s)");
                return;
            }
            string Fname = FNameTxt.Text.ToString();
            string lname = LName.Text.ToString();
            string pass = Password.Text.ToString();
            string role = Role.SelectedItem.ToString();
            string addr = Address.Text.ToString();
            int id = int.Parse(ID.Text);
           int result= CObj.InsertFlight_Crew(Fname, lname, id, addr, pass, role);
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
