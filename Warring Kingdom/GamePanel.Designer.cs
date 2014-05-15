namespace Warring_Kingdom
{
    partial class GamePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePanel));
            this.mapPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapPic)).BeginInit();
            this.SuspendLayout();
            // 
            // mapPic
            // 
            this.mapPic.Image = ((System.Drawing.Image)(resources.GetObject("mapPic.Image")));
            this.mapPic.InitialImage = null;
            this.mapPic.Location = new System.Drawing.Point(0, 0);
            this.mapPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mapPic.Name = "mapPic";
            this.mapPic.Size = new System.Drawing.Size(2133, 1108);
            this.mapPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPic.TabIndex = 0;
            this.mapPic.TabStop = false;
            this.mapPic.Click += new System.EventHandler(this.mapPic_Click);
            this.mapPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GamePanel_MouseDown);
            this.mapPic.MouseEnter += new System.EventHandler(this.GamePanel_MouseEnter);
            this.mapPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GamePanel_MouseMove);
            this.mapPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GamePanel_MouseUp);
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.mapPic);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GamePanel";
            this.Size = new System.Drawing.Size(2133, 1108);
            ((System.ComponentModel.ISupportInitialize)(this.mapPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mapPic;
    }
}
