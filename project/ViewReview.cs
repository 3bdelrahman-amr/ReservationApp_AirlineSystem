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
    public partial class ViewReview : Form
    {
        Controller CObj;
        public ViewReview()
        {
            CObj = new Controller();
            InitializeComponent();
        }

        private void FlightBut_Click(object sender, EventArgs e)
        {
            int result;
            if (FlightId.Text == ""||!int.TryParse(FlightId.Text.ToString() ,out result))
                return;

            int id = int.Parse(FlightId.Text);
            FlightReview.DataSource = CObj.GetReviewById(id);
            FlightReview.Refresh();



        }
    }
}
