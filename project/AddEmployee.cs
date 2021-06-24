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
    public partial class AddEmployee : Form
    {
        Controller CObj;Validate val;
        public AddEmployee()
        {
            InitializeComponent();
            CObj = new Controller();
            val = new Validate();
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (val.isinteger(WeeklyHours.Text, ref s) || val.isinteger(ID.Text, ref s)
                || FName.Text.ToString() == "" || LName.Text.ToString() == "" || Password.Text.ToString() == ""
                || Address.Text.ToString() == "")
            {
                MessageBox.Show("insertian failed!incorrect type(s)");
                return;
            }

            string Fname = FName.Text.ToString(); 
            string lname = LName.Text.ToString();
            string pass = Password.Text.ToString();
            int hours = int.Parse(WeeklyHours.Text); 
            string addr = Address.Text.ToString();
            int id = int.Parse(ID.Text);
            int result = CObj.InsertEmployee(Fname, lname, id, addr, pass, hours);
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
