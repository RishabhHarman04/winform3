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
    public partial class AddPatient : Form
    {
        AddPatientInfo api;
        public AddPatient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                api = new AddPatientInfo(textName.Text, textAddress.Text, Convert.ToInt64(textPhone.Text), Convert.ToInt32(textAge.Text), comboGender.Text, textBloodGroup.Text, textDisease.Text, Convert.ToInt32(textPId.Text));

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = @"INSERT INTO [dbo].[AddPatient]
           ([Name]
           ,[Full_Address]
           ,[Contact]
           ,[Age]
           ,[Gender]
           ,[Blood_Group]
           ,[Major_Disease]
           ,[pid]) VALUES('" + api.name + "','" + api.address + "'," + api.contact + "," + api.age + ",'" + api.gender  + "','" + api.blood + "','" + api.any + "'," + api.pid + ")";

                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet Ds = new DataSet();
                Da.Fill(Ds);
                MessageBox.Show(Mystrings.ApTryMessageBox);
            }
            catch (Exception)
            {
                MessageBox.Show(Mystrings.ApCtachMessageBox);

            }



            textName.Clear();
            textAddress.Clear();
            textPhone.Clear();
            textAge.Clear();
            textBloodGroup.Clear();
            textDisease.Clear();
            textPId.Clear();
            //comboGender.DropDown = String.Empty;
             comboGender.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlButtons cbc = new ControlButtons();
            cbc.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Addmoreinfo ami = new Addmoreinfo();
            ami.ShowDialog();
            this.Close();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBloodGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDisease_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textName.Text) == true)
            {
                textName.Focus();
                errorProvider1.SetError(this.textName, Mystrings.ApNameValid);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textAddress.Text) == true)
            {
                textAddress.Focus();
                errorProvider2.SetError(this.textAddress, Mystrings.ApAddressValid);
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textAddress.Text) == true)
            {
                textAddress.Focus();
                errorProvider2.SetError(this.textAddress, Mystrings.ApAddressValid);
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textAge_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textAge.Text) == true)
            {
                textAge.Focus();
                errorProvider4.SetError(this.textAge, Mystrings.ApAgeValid);
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void comboGender_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(comboGender.Text) == true)
            {
                comboGender.Focus();
                errorProvider5.SetError(this.comboGender, Mystrings.ApGenderValid);
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void textBloodGroup_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBloodGroup.Text) == true)
            {
                textBloodGroup.Focus();
                errorProvider6.SetError(this.textBloodGroup, Mystrings.ApBloodGroup);
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void textDisease_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDisease.Text) == true)
            {
                textDisease.Focus();
                errorProvider7.SetError(this.textDisease, Mystrings.ApBloodGroup);
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void textPId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textPId.Text) == true)
            {
                textPId.Focus();
                errorProvider8.SetError(this.textPId, Mystrings.ApBloodGroup);
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void textPId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void comboGender_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
