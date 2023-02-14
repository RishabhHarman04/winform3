using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject
{
    public partial class ControlButtons : Form
    {
        public ControlButtons()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {

            AddPatient ad = new AddPatient();
            ad.Show();
            this.Close();

        }

        private void btnAddDiagnosisInformation_Click(object sender, EventArgs e)
        {
            Addmoreinfo am = new Addmoreinfo();
            am.Show();
            this.Close();

        }

        private void btnFullHistoryOfProject_Click(object sender, EventArgs e)
        {


            HistoryPatient hp = new HistoryPatient();
            hp.Show();
            this.Close();

        }

        private void btnHospitalInformation_Click(object sender, EventArgs e)
        {
            Hospitalinfo hi = new Hospitalinfo();
            hi.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login lb = new Login();
            lb.Show();
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ControlButtons_Load(object sender, EventArgs e)
        {
          
        }

        private void labelindicator1_Click(object sender, EventArgs e)
        {

        }

        private void labelindicator2_Click(object sender, EventArgs e)
        {

        }

        private void labelindicator3_Click(object sender, EventArgs e)
        {

        }

        private void labelindicator4_Click(object sender, EventArgs e)
        {

        }
    }
}
