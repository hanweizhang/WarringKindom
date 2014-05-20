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
            else if (this.kdBox.Text.Equals(""))
            {
                error = "Kingdom Name is required";
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
                    string str = "EXEC Register @username='"+this.usrBox.Text+"', @userpassword='"+this.pwdBox1.Text+"', @email='"+this.emailBox.Text+"', @kingdomname='"+this.kdBox.Text+"'";
                    SqlCommand checkComm = new SqlCommand(str, conn);
                    SqlDataReader reader = checkComm.ExecuteReader();
                    if (reader.Read())
                    {
                        switch ((int)reader.GetValue(0))
                        {
                            case 1: MessageBox.Show("Username already taken"); break;
                            case 2: MessageBox.Show("Email already taken"); break;
                            case 3: MessageBox.Show("Kingdom name already taken"); break;
                            default: MessageBox.Show("Error"); break;
                        }
                        conn.Close();
                        return false;
                    }
                    reader.Close();
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

        private void RegForm_Load(object sender, EventArgs e)
        {

        }
    }
}
