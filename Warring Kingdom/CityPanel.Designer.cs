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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityPanel));
            this.backBtn = new System.Windows.Forms.Button();
            this.cityPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cityPic)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backBtn.ForeColor = System.Drawing.Color.Gold;
            this.backBtn.Location = new System.Drawing.Point(20, 21);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(105, 41);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // cityPic
            // 
            this.cityPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cityPic.Image = ((System.Drawing.Image)(resources.GetObject("cityPic.Image")));
            this.cityPic.InitialImage = null;
            this.cityPic.Location = new System.Drawing.Point(0, 0);
            this.cityPic.Name = "cityPic";
            this.cityPic.Size = new System.Drawing.Size(1600, 900);
            this.cityPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cityPic.TabIndex = 0;
            this.cityPic.TabStop = false;
            this.cityPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CityPanel_MouseDown);
            this.cityPic.MouseEnter += new System.EventHandler(this.CityPanel_MouseEnter);
            this.cityPic.MouseHover += new System.EventHandler(this.CityPanel_MouseHover);
            // 
            // CityPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.cityPic);
            this.Location = new System.Drawing.Point(275, 76);
            this.Name = "CityPanel";
            this.Size = new System.Drawing.Size(1600, 900);
            ((System.ComponentModel.ISupportInitialize)(this.cityPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cityPic;
        private System.Windows.Forms.Button backBtn;
    }
}
