using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsGUI
{
    public partial class frmEnterPage : Form
    {
        public frmEnterPage()
        {
            InitializeComponent();
            this.Text = "Welcome";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //The login page is just a mockup, no functionality.
            frmMain main = new frmMain();
            main.EnterPage = this;
            main.Show();
            this.Hide();
        }
    }
}
