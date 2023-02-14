using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace HospitalProject
{
    public partial class Login : Form

    {
        SqlQuery sq;
        LoginInfo li;

        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            li = new LoginInfo(textusername.Text, textpassword.Text);
            sq = new SqlQuery();

            if (string.IsNullOrEmpty(li.emailid) == true)
            {
                textusername.Focus();
                errorProvider1.SetError(this.textusername, Mystrings.EmailLogin);
            }
            else if (string.IsNullOrEmpty(li.password) == true)
            {
                textpassword.Focus();
                errorProvider2.SetError(this.textpassword, Mystrings.PasswordLogin);
            }
            else
            {
                try
                {
                    DataTable dt = sq.Selectinlogin(li);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show(Mystrings.LoginTRyifMessage);
                        ControlButtons c = new ControlButtons();
                        c.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(Mystrings.LoginTRyelseMessage);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(Mystrings.LoginCatchMessage + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Mystrings.LoginSecCatchMessage + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Welcome w = new Welcome();
            w.Show();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            
        }

        private void textusername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textusername.Text) == true)
            {
                textusername.Focus();
                errorProvider1.SetError(this.textusername, Mystrings.EmailLogin);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textpassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textpassword.Text) == true)
            {
                textpassword.Focus();
                errorProvider2.SetError(this.textpassword, Mystrings.PasswordLogin);
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

