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
            this.title.Location = new System.Drawing.Point(this.titlePanel.Width/2-this.title.Width/2, this.titlePanel.Height/2-this.title.Height/2-2);
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
            this.title.Location = new System.Drawing.Point(this.titlePanel.Width / 2 - this.title.Width / 2, this.titlePanel.Height / 2 - this.title.Height / 2 - 2);
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void refreshMap()
        {
            this.gamePanel1.Dispose();
            this.gamePanel1 = new Warring_Kingdom.GamePanel();
            this.gamePanel1.setUser(username);
            this.gamePanel1.setForm(this);
            // 
            // gamePanel1
            // 
            this.gamePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gamePanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamePanel1.Location = new System.Drawing.Point(275, 100);
            this.gamePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gamePanel1.Name = "gamePanel1";
            this.gamePanel1.Size = new System.Drawing.Size(1600, 900);
            this.gamePanel1.TabIndex = 3;
            this.Controls.Add(this.gamePanel1);
        }

        public void hideRefreshBtn()
        {
            this.RefreshBtn.Hide();
        }

        public void showRefreshBtn()
        {
            this.RefreshBtn.Show();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            refreshMap();
            updateUserInfo();
        }

        public void updateUserInfo()
        {
            this.infoPanel1.getData(this.username);
        }
    }
}
