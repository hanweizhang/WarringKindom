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
    public partial class NewCityForm : Form
    {
        private string username;
        private string landname;
        private GameForm gameForm;

        public NewCityForm(string username, string landname, GameForm gameForm)
        {
            InitializeComponent();
            this.username = username;
            this.landname = landname;
            this.gameForm = gameForm;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (this.cityBox.Text.Equals(""))
            {
                MessageBox.Show("City name is required");
            }
            else
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
                        string str = "EXEC CreateCity @Username='" + this.username + "', @Landname='" + this.landname + "', @CityName='" + this.cityBox.Text + "'";
                        SqlCommand checkComm = new SqlCommand(str, conn);
                        SqlDataReader reader = checkComm.ExecuteReader();
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        conn.Close();
                    }
                    // close the connection
                    conn.Close();
                    MessageBox.Show("Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                this.gameForm.refreshMap();
                this.gameForm.updateUserInfo();
                this.Dispose();
            }
        }
    }
}
