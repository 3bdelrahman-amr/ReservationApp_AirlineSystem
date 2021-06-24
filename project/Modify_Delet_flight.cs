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
    public partial class Modify_Delet_flight : Form
    {
        Controller CObj;
        public Modify_Delet_flight()
        {
            CObj = new Controller();
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flightnumb = int.Parse(FlightNumb.Text);//to be validate after i finish
            FlightView.DataSource = CObj.SelectFlyByNumb(flightnumb);
            FlightView.Refresh();
          // FlightView.Rows[0].ReadOnly = true;

        }

        private void ModifyBut_Click(object sender, EventArgs e)
        {
            string item = ModifyBox.SelectedItem.ToString();
            
            if (item == null)
                   return;
            else if (item == "PassengerNo")
            {
                int no = int.Parse(FlightView.Rows[0].Cells[0].Value.ToString());
                int value = int.Parse(ModValue.Text);
                CObj.UpdateFlightPassNo(no, value);
            }
            else if (item == "FlightStatus")
            {
               
                int no = int.Parse(FlightView.Rows[0].Cells[0].Value.ToString());
                string value = StatusBox.SelectedItem.ToString(); 
                CObj.UpdateFlightStatus(no, value);
            }
            else if ( item == "DestCode")
            {
                int no = int.Parse(FlightView.Rows[0].Cells[0].Value.ToString());
                int value = int.Parse(ModValue.Text);
                CObj.UpdateFlightDest(no, value);
            }
            else if (item == "SourceCode")
            {
                int no = int.Parse(FlightView.Rows[0].Cells[0].Value.ToString());
                int value = int.Parse(ModValue.Text);
                CObj.UpdateFlightSource(no, value);
            }
            else if (item == "NoStuff")
            {
                int no = int.Parse(FlightView.Rows[0].Cells[0].Value.ToString());
                int value = int.Parse(ModValue.Text);
                CObj.UpdateFlightNoStaff(no, value);
            }

            int flightnumb = int.Parse(FlightNumb.Text);//to be validate after i finish
            FlightView.DataSource = CObj.SelectFlyByNumb(flightnumb);
            FlightView.Refresh();



        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int no = int.Parse(FlightView.Rows[0].Cells[0].Value.ToString());
            CObj.DeleteFlight(no);
            int flightnumb = int.Parse(FlightNumb.Text);//to be validate after i finish
            FlightView.DataSource = CObj.SelectFlyByNumb(flightnumb);
            FlightView.Refresh();

        }
    }
}
