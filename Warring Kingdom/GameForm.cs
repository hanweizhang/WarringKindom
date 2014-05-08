﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warring_Kingdom
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            this.cityPanel = new CityPanel(this);
            this.title.Location = new System.Drawing.Point(this.titlePanel.Width/2-this.title.Width/2, this.titlePanel.Height/2-this.title.Height/2);
        }



        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cityBtn_Click(object sender, EventArgs e)
        {
            cityEnter();
            this.Controls.Add(new CityPanel(this));
        }

        public void cityEnter()
        {
            this.gamePanel1.Hide();
            this.infoPanel1.Hide();
            this.cityBtn1.Hide();
            this.cityBtn2.Hide();
            this.menuBtn.Hide();
            this.infoPanel1.Hide();
            this.titlePanel.Hide();
        }

        public void cityExit()
        {
            this.gamePanel1.Show();
            this.infoPanel1.Show();
            this.cityBtn1.Show();
            this.cityBtn2.Show();
            this.menuBtn.Show();
            this.infoPanel1.Show();
            this.titlePanel.Show();
        }

        public void saveCity(CityPanel cityPanel)
        {
            this.cityPanel = cityPanel;
        }

        private CityPanel cityPanel;
    }
}