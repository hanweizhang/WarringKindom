using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warring_Kingdom
{
    public partial class InfoPanel : UserControl
    {
        private const int LINE_SPACE = 40;

        public InfoPanel()
        {
            InitializeComponent();
            rearrangePos();
        }

        private void rearrangePos()
        {
            int startX = this.nameLabel.Location.X;
            int startY = this.nameLabel.Location.Y;
            // nameLabel remains unchanged
            // name
            this.name.Location = new System.Drawing.Point(startX, startY+this.nameLabel.Height);
            // kingdomLabel
            this.kingdomLabel.Location = new System.Drawing.Point(startX, this.name.Location.Y + this.name.Height+LINE_SPACE);
            // kingdom
            this.kingdom.Location = new System.Drawing.Point(startX, this.kingdomLabel.Location.Y + this.kingdomLabel.Height);
            // armyLabel
            this.armyLabel.Location = new System.Drawing.Point(startX, this.kingdom.Location.Y + this.kingdom.Height + LINE_SPACE);
            // army
            this.army.Location = new System.Drawing.Point(startX, this.armyLabel.Location.Y + this.armyLabel.Height);
            // goldLabel
            this.goldLabel.Location = new System.Drawing.Point(startX, this.army.Location.Y + this.army.Height + LINE_SPACE);
            // gold
            this.gold.Location = new System.Drawing.Point(startX, this.goldLabel.Location.Y + this.goldLabel.Height);
        }

        public void getData(string username)
        {
            try
            {
                // connect to the server
                String connectStr = "server=titan.csse.rose-hulman.edu; uid=wkuser; pwd=wkuser; database=WarKing";
                SqlConnection conn = new SqlConnection(connectStr);
                conn.Open();
                // get the information
                try
                {
                    String comm = "EXEC GetInfo @username='"+username+"'";
                    SqlCommand selectComm = new SqlCommand(comm, conn);
                    SqlDataReader reader = selectComm.ExecuteReader();
                    reader.Read();
                    this.name.Text = username;
                    this.kingdom.Text = (String)reader.GetValue(0);
                    this.army.Text = reader.GetValue(1)+"";
                    this.gold.Text = reader.GetValue(2)+"";
                    reader.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
