using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject
{
    internal class SqlQuery
    {
        SqlConnection con;
        SqlCommand cmd;
        public SqlQuery()
        {
            con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            cmd = new SqlCommand();
            cmd.Connection = con;

        }
        public void Insertintoregistration(Registerinfo ri)
        {
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO [dbo].[Register]
                   
               ([User name]
               ,[Emailid]
               ,[Password]
               ,[Confirmpass])
         VALUES
              (@username, @email, @password, @confirmpassword)";
                cmd.Parameters.AddWithValue("@username", ri.name);
                cmd.Parameters.AddWithValue("@email", ri.email);
                cmd.Parameters.AddWithValue("@password", ri.password);
                cmd.Parameters.AddWithValue("@confirmpassword", ri.confirmpassword);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable Selectinlogin(LoginInfo li)
        {
            DataTable dt = new DataTable();
            try
            {
                string sqlquery = " select * from [dbo].[Register] where Emailid=@Emailid and Password=@Password";
                con.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, con);
                sqlcomm.Parameters.AddWithValue("@Emailid", li.emailid);
                sqlcomm.Parameters.AddWithValue("@Password", li.password);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                sda.Fill(dt);
                sqlcomm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}
