using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject
{

    public partial class Registration : Form

    {
        SqlQuery sqc = new SqlQuery();
        Registerinfo ri;
        string emailpattern = @Mystrings.Emailpattern;
        string password = @Mystrings.Passwordpattern;

        public Registration()
        {
            InitializeComponent();
        }

        private void Btnregister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxReguser.Text) == true)
            {
                textBoxReguser.Focus();
                errorProvider1.SetError(this.textBoxReguser, Mystrings.Username_Validation);
            }
            else if (Regex.IsMatch(textBoxregemail.Text, emailpattern) == false)
            {
                textBoxregemail.Focus();
                errorProvider2.SetError(this.textBoxregemail, Mystrings.Email__Validation);

            }
            else if (Regex.IsMatch(textBoxregpass.Text, password) == false)
            {
                textBoxregpass.Focus();
                errorProvider3.SetError(this.textBoxregpass, Mystrings.Password_Validation);
            }
            else if (textBoxregcp.Text != textBoxregpass.Text)
            {
                textBoxregcp.Focus();
                errorProvider4.SetError(this.textBoxregcp, Mystrings.Confirm_Password_Validation);
            }

            else
            {
                try
                {
                    ri = new Registerinfo(textBoxReguser.Text, textBoxregemail.Text, textBoxregpass.Text, textBoxregcp.Text);
                 
                    sqc.Insertintoregistration(ri);

                    Login l = new Login();
                    l.Show();
                    this.Close();

                }


                catch (Exception ex)
                {
                    MessageBox.Show(Mystrings.Exception + ex.Message);
                }
               
            }

        }

        private void btnalreday_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void textBoxReguser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxReguser.Text) == true)
            {
                textBoxReguser.Focus();
                errorProvider1.SetError(this.textBoxReguser, Mystrings.Username_Validation);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBoxReguser_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxregemail_Leave(object sender, EventArgs e)
        {
            if (ri!= null && ri.ValidateEmail()==false)
            {
                textBoxregemail.Focus();
                errorProvider2.SetError(this.textBoxregemail, Mystrings.Email__Validation);

            }
            else
            {
                errorProvider2.Clear();
            }

        }

        private void textBoxregpass_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxregpass.Text, password) == false)
            {
                textBoxregpass.Focus();
                errorProvider3.SetError(this.textBoxregpass, Mystrings.Password_Validation);
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBoxregcp_Leave(object sender, EventArgs e)
        {
            if (textBoxregcp.Text != textBoxregpass.Text)
            {
                textBoxregcp.Focus();
                errorProvider4.SetError(this.textBoxregcp, Mystrings.Confirm_Password_Validation);
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            w.Show();
            this.Close();

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            

        }

        private void textBoxReguser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxregemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxregpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxregcp_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
