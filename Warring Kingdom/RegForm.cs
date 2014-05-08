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

namespace Warring_Kingdom
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                if (createUser())
                {
                    this.Close();
                }
            }
        }

        private bool checkInput()
        {
            String error = "";
            if (this.usrBox.Text.Equals(""))
            {
                error = "Username is required";
            }
            else if (this.emailBox.Text.Equals(""))
            {
                error = "Email is required";
            }
            else if (this.pwdBox1.Text.Equals(""))
            {
                error = "Password is required";
            }
            else if (!this.pwdBox1.Text.Equals(this.pwdBox2.Text))
            {
                error = "Passwords do not match";
            }
            if (error.Equals(""))
            {
                return true;
            }
            else
            {
                MessageBox.Show(error);
                return false;
            }
        }

        private bool createUser()
        {
            try
            {
                // connect to the server
                String connectStr = "server=titan.csse.rose-hulman.edu; uid=wkuser; pwd=wkuser; database=WarKing";
                SqlConnection conn = new SqlConnection(connectStr);
                conn.Open();
                // insert the user information into the database
                try
                {
                    // check if username already exist
                    SqlCommand checkComm = new SqlCommand("SELECT * FROM [UserInfo] WHERE Username='" + this.usrBox.Text + "'", conn);
                    SqlDataReader reader = checkComm.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Username already taken");
                        conn.Close();
                        return false;
                    }
                    reader.Close();
                    // create the user
                    SqlCommand insertComm = new SqlCommand("INSERT INTO [UserInfo](Username,[Email],Userpassword) VALUES('" + this.usrBox.Text + "','" + this.emailBox.Text + "','" + this.pwdBox1.Text + "')", conn);
                    int result = insertComm.ExecuteNonQuery();
                    if(result!=1){
                        MessageBox.Show("Fail to create the user, try again");
                        conn.Close();
                        return false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    conn.Close();
                    return false;
                }
                // close the connection
                conn.Close();
                MessageBox.Show("Success");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
    }
}
