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
    public partial class GameForm : Form
    {
        private string username;

        public GameForm()
        {
            InitializeComponent();
            this.title.Location = new System.Drawing.Point(this.titlePanel.Width/2-this.title.Width/2, this.titlePanel.Height/2-this.title.Height/2);
        }

        public GameForm(string username)
        {
            this.username = username;
            InitializeComponent();
            this.title.Location = new System.Drawing.Point(this.titlePanel.Width / 2 - this.title.Width / 2, this.titlePanel.Height / 2 - this.title.Height / 2);
            this.gamePanel1.setUser(username);
            this.gamePanel1.setForm(this);
            initInfoPanel(username);
        }

        private void initInfoPanel(string username)
        {
            this.infoPanel1.getData(username);
        }

        public void setTitle(string title)
        {
            this.title.Text = title;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
