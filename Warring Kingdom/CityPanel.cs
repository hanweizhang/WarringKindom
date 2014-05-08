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
    public partial class CityPanel : UserControl
    {
        public CityPanel(GameForm gameForm)
        {
            InitializeComponent();
            this.currentEmptyLand = new System.Windows.Forms.Button();
            this.gameForm = gameForm;
        }


        private void emptyLand_Click(object sender, EventArgs e)
        {
            this.currentEmptyLand = ((Button)sender);
            this.Controls.Add(this.buildingBtn1);
            this.Controls.Add(this.constructionPic);
            this.Controls.Add(this.exitBtn);
            this.constructionPic.BringToFront();
            this.buildingBtn1.BringToFront();
            this.exitBtn.BringToFront();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.buildingBtn1.Dispose();
            this.constructionPic.Dispose();
            this.exitBtn.Dispose();
        }

        private void buildingBtn_Click(object sender, EventArgs e)
        {
            constructNewBuilding(this.currentEmptyLand.Location);
            this.currentEmptyLand.Dispose();
            this.buildingBtn1.Dispose();
            this.constructionPic.Dispose();
            this.exitBtn.Dispose();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.gameForm.cityExit();
            this.Dispose();
            
        }

        private void constructNewBuilding(Point location)
        {
            System.Windows.Forms.Button newBuilding = new System.Windows.Forms.Button();
            newBuilding.BackColor = System.Drawing.Color.Transparent;
            newBuilding.BackgroundImage = global::Warring_Kingdom.Properties.Resources.building_1;
            newBuilding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            newBuilding.Cursor = System.Windows.Forms.Cursors.Hand;
            newBuilding.FlatAppearance.BorderSize = 0;
            newBuilding.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            newBuilding.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            newBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            newBuilding.ForeColor = System.Drawing.Color.Transparent;
            newBuilding.Location = location;
            newBuilding.Margin = new System.Windows.Forms.Padding(0);
            newBuilding.Name = "newBuilding";
            newBuilding.Size = new System.Drawing.Size(120, 120);
            newBuilding.TabIndex = 0;
            newBuilding.UseVisualStyleBackColor = true;
            this.Controls.Add(newBuilding);
            newBuilding.BringToFront();
            
        }

        private System.Windows.Forms.Button currentEmptyLand;
        private GameForm gameForm;

    }
}
