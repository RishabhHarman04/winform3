using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject
{
    public partial class Addmoreinfo : Form
    {
        AddPatientMoreInfo apm;
        public Addmoreinfo()
        {
            InitializeComponent();
        }

        private void textSymptoms_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textSymptoms.Text) == true)
            {
                textSymptoms.Focus();
                errorProvider1.SetError(this.textSymptoms, Mystrings.AmSymptomValid);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textDiagnosis_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDiagnosis.Text) == true)
            {
                textDiagnosis.Focus();
                errorProvider2.SetError(this.textDiagnosis, Mystrings.AmDiagnosisValid);
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textMedicines_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textMedicines.Text) == true)
            {
                textMedicines.Focus();
                errorProvider3.SetError(this.textMedicines, Mystrings.AmMedicineValid);
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void comboBoxWard_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxWard.Text) == true)
            {
                comboBoxWard.Focus();
                errorProvider4.SetError(this.comboBoxWard, Mystrings.AmWardValid);
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void comboBoxWardType_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxWardType.Text) == true)
            {
                comboBoxWardType.Focus();
                errorProvider5.SetError(this.comboBoxWardType, Mystrings.AmWardTypeValid);
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" )
            {
                int pid = Convert.ToInt32(textBox1.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT *FROM AddPatient where pid=" + pid + "";
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                Da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textSymptoms.Text) == true)
            {
                textSymptoms.Focus();
                errorProvider1.SetError(this.textSymptoms, Mystrings.AmSymptomValid);
            }

            else if (string.IsNullOrEmpty(comboBoxWard.Text) == true)
            {
                comboBoxWard.Focus();
                errorProvider4.SetError(this.comboBoxWard, Mystrings.AmWardValid);
            }
            else if (string.IsNullOrEmpty(textDiagnosis.Text) == true)
            {
                textDiagnosis.Focus();
                errorProvider2.SetError(this.textDiagnosis, Mystrings.AmDiagnosisValid);
            }
            else if (string.IsNullOrEmpty(comboBoxWardType.Text) == true)
            {
                comboBoxWardType.Focus();
                errorProvider5.SetError(this.comboBoxWardType, Mystrings.AmWardTypeValid);
            }

            else if (string.IsNullOrEmpty(textMedicines.Text) == true)
            {
                textMedicines.Focus();
                errorProvider3.SetError(this.textMedicines, Mystrings.AmMedicineValid);
            }
            else
            {
                try
                {
                    apm = new AddPatientMoreInfo(Convert.ToInt32(textBox1.Text), textSymptoms.Text, textDiagnosis.Text, textMedicines.Text, comboBoxWard.Text, comboBoxWardType.Text, dateTimePicker1.Text);
                    
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "INSERT INTO PatientMore VALUES('" + apm.pid + "','" + apm.sympt + "','" + apm.diag + "','" + apm.medicine + "','" +apm.ward + "','" + apm.wardtype + "','" + apm.date + "')";
                    SqlDataAdapter Da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    Da.Fill(ds);


                    MessageBox.Show(Mystrings.AmTryMessageBox);

                }
                catch (Exception)
                {
                    MessageBox.Show(Mystrings.AmCatchBox);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPatient apb = new AddPatient();
            apb.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            HistoryPatient hp = new HistoryPatient();
            hp.Show();
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Addmoreinfo_Load(object sender, EventArgs e)
        {
            
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
           
            
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["pid"].Value != DBNull.Value)
            {
                if(MessageBox.Show(Mystrings.AmDeleteMessage, "dataGridView1",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString))
                    {
                        con.Open();
                        SqlCommand sqlCmd = new SqlCommand("RecordDeleteById", con);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@pid", Convert.ToInt32(dataGridView1.CurrentRow.Cells["pid"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textSymptoms_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDiagnosis_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMedicines_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxWard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxWardType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }
    }
}