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
    public partial class Ban_UnbamClient : Form
    {
        Controller CObj;
        public Ban_UnbamClient()
        {
            CObj = new Controller();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int res;

            if (clientId.Text == "" || !int.TryParse(clientId.Text, out res))//validation that it is intger and not empty
                return;
            int id = int.Parse(clientId.Text);//to be validate after i finish
            ClientView.DataSource = CObj.SelectClient(id);
            ClientView.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res;
            
            if (clientId.Text == "" || !int.TryParse(clientId.Text, out res))//validation that it is intger and not empty
                return;
              
            
            int id = int.Parse(clientId.Text);
            object ban = CObj.getBanStatus(id);
            int result;
            if (ban.ToString() == "True")
               result= CObj.UpdateBan(id, 0);
            else
                result=CObj.UpdateBan(id, 1);
            ClientView.DataSource = CObj.SelectClient(id);
            ClientView.Refresh();
        }

        //private void clientId_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
