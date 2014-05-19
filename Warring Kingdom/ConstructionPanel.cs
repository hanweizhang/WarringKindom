using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warring_Kingdom
{
    public partial class ConstructionPanel : UserControl
    {
        private int index;
        private CityPanel cityPanel;

        public ConstructionPanel()
        {
            InitializeComponent();
            this.index = 1;
        }

        public ConstructionPanel(CityPanel cityPanel)
        {
            InitializeComponent();
            this.cityPanel = cityPanel;
        }

        public void setIndex(int index)
        {
            this.index = index;
        }

        public void setCity(CityPanel cityPanel)
        {
            this.cityPanel = cityPanel;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void building_Click(object sender, EventArgs e)
        {
            if (sender.Equals(pictureBox1))
            {
                this.cityPanel.updateLand(1, this.index);
            }
            else if (sender.Equals(pictureBox2))
            {
                this.cityPanel.updateLand(2, this.index);
            }
            else if (sender.Equals(pictureBox3))
            {
                this.cityPanel.updateLand(3, this.index);
            }
            else if (sender.Equals(pictureBox4))
            {
                this.cityPanel.updateLand(4, this.index);
            }
            else if (sender.Equals(pictureBox5))
            {
                this.cityPanel.updateLand(5, this.index);
            }
            else if (sender.Equals(pictureBox6))
            {
                this.cityPanel.updateLand(6, this.index);
            }
            else if (sender.Equals(pictureBox7))
            {
                this.cityPanel.updateLand(7, this.index);
            }
            else if (sender.Equals(pictureBox8))
            {
                this.cityPanel.updateLand(8, this.index);
            }
            else if (sender.Equals(pictureBox9))
            {
                this.cityPanel.updateLand(9, this.index);
            }
            else if (sender.Equals(pictureBox10))
            {
                this.cityPanel.updateLand(10, this.index);
            }
            else if (sender.Equals(pictureBox11))
            {
                this.cityPanel.updateLand(11, this.index);
            }
            this.Hide();
        }

        private void ConstructionPanel_MouseEnter(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
