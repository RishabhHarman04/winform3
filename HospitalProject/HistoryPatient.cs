using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject
{
    public partial class HistoryPatient : Form
    {
        public HistoryPatient()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT *FROM AddPatient inner join PatientMore on AddPatient.pid=PatientMore.pid";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            Da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hospitalinfo hi = new Hospitalinfo();
            hi.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addmoreinfo amb = new Addmoreinfo();
            amb.Show();
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT *FROM AddPatient inner join PatientMore on AddPatient.pid=PatientMore.pid";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            Da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void HistoryPatient_Load(object sender, EventArgs e)
        {
           
        }
    }
}
