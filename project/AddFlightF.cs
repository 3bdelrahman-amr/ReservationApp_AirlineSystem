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
    public partial class AddFlightF : Form
    {
        Controller CObj;
        Validate val;
        public AddFlightF()
        {
            InitializeComponent();
            val = new Validate();
            CObj = new Controller();
        }

        private void AddFlightF_Load(object sender, EventArgs e)
        {

        }


        ///////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            int s = 0;
            if(val.isinteger(StuffNumbTxt.Text,ref s)||StuffNumbTxt.Text==""|| val.isinteger(NoOfPassTxt.Text, ref s)
                || NoOfPassTxt.Text==""|| val.isinteger(FlightNumbTxt.Text, ref s)|| FlightNumbTxt.Text==""
                || val.isinteger(ArrivalCodeTxt.Text, ref s)|| ArrivalCodeTxt.Text==""
                || val.isinteger(DepartureTxt.Text, ref s) || DepartureTxt.Text == ""
                || StatusBox.SelectedItem.ToString()==""
                )
            {
                MessageBox.Show("insertian failed!incorrect type(s)");
                return;
            }


            string status = StatusBox.SelectedItem.ToString();
            int StuffNumb = int.Parse(StuffNumbTxt.Text);
            int NoOfPass = int.Parse(NoOfPassTxt.Text);
            int FlightNumb = int.Parse(FlightNumbTxt.Text);
            int destenation = int.Parse(ArrivalCodeTxt.Text);
            int Source = int.Parse(DepartureTxt.Text);
            int result=CObj.InsertFlight(StuffNumb, Source, destenation, status, FlightNumb, NoOfPass);
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
