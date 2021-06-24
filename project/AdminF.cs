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
    public partial class AdminF : Form
    {
        public AdminF()
        {
            InitializeComponent();
        }

        private void Flight_Click(object sender, EventArgs e)
        {
            AddFlightF f = new AddFlightF();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmployee emp = new AddEmployee();
            emp.Show();
        }

        private void FlightCrew_Click(object sender, EventArgs e)
        {
            AddFlightCrew crew = new AddFlightCrew();
            crew.Show();
        }

        private void Plane_Click(object sender, EventArgs e)
        {
            AddPlaneF plane = new AddPlaneF();
            plane.Show();
        }

        private void Ban_Click(object sender, EventArgs e)
        {
            Ban_UnbamClient ban = new Ban_UnbamClient();
            ban.Show();
        }

        private void ModDelFlight_Click(object sender, EventArgs e)
        {
            Modify_Delet_flight modFlight = new Modify_Delet_flight();
            modFlight.Show();
        }

        private void PlaneStatus_Click(object sender, EventArgs e)
        {
            UpdatePlaneStatus status = new UpdatePlaneStatus();
            status.Show();
        }

        private void Review_Click(object sender, EventArgs e)
        {
            ViewReview review = new ViewReview();
            review.Show();
        }

        private void Airport_Click(object sender, EventArgs e)
        {
            AddAirPortF airport = new AddAirPortF();
            airport.Show();
        }

        private void ViewF_Click(object sender, EventArgs e)
        {
            VFlights v = new VFlights();
            v.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VClients c = new VClients();
            c.Show();
        }
    }
}
