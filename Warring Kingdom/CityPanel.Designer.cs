namespace Warring_Kingdom
{
    partial class CityPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buildingBtn1 = new System.Windows.Forms.Button();
            this.emptyLand = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.cityPic = new System.Windows.Forms.PictureBox();
            this.constructionPic = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cityPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionPic)).BeginInit();
            this.SuspendLayout();
            // 
            // buildingBtn1
            // 
            this.buildingBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buildingBtn1.BackgroundImage = global::Warring_Kingdom.Properties.Resources.building_1;
            this.buildingBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buildingBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildingBtn1.FlatAppearance.BorderSize = 0;
            this.buildingBtn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buildingBtn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buildingBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildingBtn1.ForeColor = System.Drawing.Color.Transparent;
            this.buildingBtn1.Location = new System.Drawing.Point(138, 743);
            this.buildingBtn1.Margin = new System.Windows.Forms.Padding(0);
            this.buildingBtn1.Name = "buildingBtn1";
            this.buildingBtn1.Size = new System.Drawing.Size(120, 120);
            this.buildingBtn1.TabIndex = 5;
            this.buildingBtn1.UseVisualStyleBackColor = true;
            this.buildingBtn1.Click += new System.EventHandler(this.buildingBtn_Click);
            // 
            // emptyLand
            // 
            this.emptyLand.BackColor = System.Drawing.Color.Transparent;
            this.emptyLand.BackgroundImage = global::Warring_Kingdom.Properties.Resources.empty_land;
            this.emptyLand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emptyLand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emptyLand.FlatAppearance.BorderSize = 0;
            this.emptyLand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.emptyLand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.emptyLand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emptyLand.ForeColor = System.Drawing.Color.Transparent;
            this.emptyLand.Location = new System.Drawing.Point(736, 400);
            this.emptyLand.Margin = new System.Windows.Forms.Padding(0);
            this.emptyLand.Name = "emptyLand";
            this.emptyLand.Size = new System.Drawing.Size(120, 130);
            this.emptyLand.TabIndex = 2;
            this.emptyLand.UseVisualStyleBackColor = true;
            this.emptyLand.Click += new System.EventHandler(this.emptyLand_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(20, 21);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(97, 37);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // cityPic
            // 
            this.cityPic.Image = global::Warring_Kingdom.Properties.Resources.city_land;
            this.cityPic.InitialImage = null;
            this.cityPic.Location = new System.Drawing.Point(0, 0);
            this.cityPic.Name = "cityPic";
            this.cityPic.Size = new System.Drawing.Size(1600, 900);
            this.cityPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cityPic.TabIndex = 0;
            this.cityPic.TabStop = false;
            // 
            // constructionPic
            // 
            this.constructionPic.Image = global::Warring_Kingdom.Properties.Resources.border;
            this.constructionPic.InitialImage = null;
            this.constructionPic.Location = new System.Drawing.Point(0, 680);
            this.constructionPic.Name = "constructionPic";
            this.constructionPic.Size = new System.Drawing.Size(1920, 300);
            this.constructionPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.constructionPic.TabIndex = 0;
            this.constructionPic.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(338, 743);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(129, 46);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // CityPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.emptyLand);
            this.Controls.Add(this.cityPic);
            this.Name = "CityPanel";
            this.Size = new System.Drawing.Size(1600, 900);
            ((System.ComponentModel.ISupportInitialize)(this.cityPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cityPic;
        private System.Windows.Forms.PictureBox constructionPic;
        private System.Windows.Forms.Button buildingBtn1;
        private System.Windows.Forms.Button emptyLand;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button backBtn;
    }
}
