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
    public partial class OtherCityInfo : Form
    {
        private string username;
        private string cityName;
        private GameForm gameForm;

        public OtherCityInfo(string username, string cityName, GameForm gameForm)
        {
            InitializeComponent();
            this.username = username;
            this.cityName = cityName;
            this.gameForm = gameForm;
            initCityInfo();
            initComboBox();
        }

        private void initCityInfo()
        {
            try
            {
                // connect to the server
                String connectStr = "server=titan.csse.rose-hulman.edu; uid=wkuser; pwd=wkuser; database=WarKing";
                SqlConnection conn = new SqlConnection(connectStr);
                conn.Open();
                // get all city names
                try
                {
                    string str = "EXEC GetCityInfo @Cityname='"+this.cityName+"'";
                    SqlCommand checkComm = new SqlCommand(str, conn);
                    SqlDataReader reader = checkComm.ExecuteReader();
                    if (reader.Read())
                    {
                        this.cityNameLabel.Text = this.cityName;
                        this.ownerNameLabel.Text = (string)reader.GetValue(0);
                        this.armyNumLabel.Text = ((int)reader.GetValue(1)) + "";
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
                // close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void initComboBox()
        {
            List<string> cityList = new List<string>();
            cityList.Add("");
            try
            {
                // connect to the server
                String connectStr = "server=titan.csse.rose-hulman.edu; uid=wkuser; pwd=wkuser; database=WarKing";
                SqlConnection conn = new SqlConnection(connectStr);
                conn.Open();
                // get all city names
                try
                {
                    string str = "EXEC AllCity @Username='"+this.username+"'";
                    SqlCommand checkComm = new SqlCommand(str, conn);
                    SqlDataReader reader = checkComm.ExecuteReader();
                    while (reader.Read())
                    {
                        cityList.Add((string)reader.GetValue(0));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
                // close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.comboBox1.DataSource = cityList;
        }

        private void AttackBtn_Click(object sender, EventArgs e)
        {
            bool isCaptured = false;
            try
            {
                // connect to the server
                String connectStr = "server=titan.csse.rose-hulman.edu; uid=wkuser; pwd=wkuser; database=WarKing";
                SqlConnection conn = new SqlConnection(connectStr);
                conn.Open();
                // get all city names
                try
                {
                    string str = "EXEC Attack @Cityname1='" + this.cityName + "', @Cityname2='"+(string)this.comboBox1.SelectedItem+"'";
                    SqlCommand checkComm = new SqlCommand(str, conn);
                    SqlDataReader reader = checkComm.ExecuteReader();
                    if (reader.Read()) {
                        if ((int)reader.GetValue(0) == 1)
                        {
                            isCaptured = true;
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
                // close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (isCaptured)
            {
                MessageBox.Show("City Captured!");
                this.gameForm.refreshMap();
            }
            else
            {
                MessageBox.Show("Failed...");
            }
            this.gameForm.updateUserInfo();
            this.Dispose();
        }

    }
}
