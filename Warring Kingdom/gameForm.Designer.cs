namespace Warring_Kingdom
{
    partial class GameForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.menuBtn = new System.Windows.Forms.Button();
            this.cityBtn1 = new System.Windows.Forms.Button();
            this.cityBtn2 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.infoPanel1 = new Warring_Kingdom.InfoPanel();
            this.gamePanel1 = new Warring_Kingdom.GamePanel();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuBtn.BackColor = System.Drawing.Color.Transparent;
            this.menuBtn.BackgroundImage = global::Warring_Kingdom.Properties.Resources.menu;
            this.menuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.ForeColor = System.Drawing.Color.Transparent;
            this.menuBtn.Location = new System.Drawing.Point(1847, 9);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(0);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(64, 64);
            this.menuBtn.TabIndex = 0;
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // cityBtn1
            // 
            this.cityBtn1.BackColor = System.Drawing.Color.Transparent;
            this.cityBtn1.BackgroundImage = global::Warring_Kingdom.Properties.Resources.icon_1;
            this.cityBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cityBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cityBtn1.FlatAppearance.BorderSize = 0;
            this.cityBtn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cityBtn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cityBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cityBtn1.ForeColor = System.Drawing.Color.Transparent;
            this.cityBtn1.Location = new System.Drawing.Point(116, 522);
            this.cityBtn1.Margin = new System.Windows.Forms.Padding(0);
            this.cityBtn1.Name = "cityBtn1";
            this.cityBtn1.Size = new System.Drawing.Size(64, 64);
            this.cityBtn1.TabIndex = 0;
            this.cityBtn1.UseVisualStyleBackColor = true;
            this.cityBtn1.Click += new System.EventHandler(this.cityBtn_Click);
            // 
            // cityBtn2
            // 
            this.cityBtn2.BackColor = System.Drawing.Color.Transparent;
            this.cityBtn2.BackgroundImage = global::Warring_Kingdom.Properties.Resources.icon_2;
            this.cityBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cityBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cityBtn2.FlatAppearance.BorderSize = 0;
            this.cityBtn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cityBtn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cityBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cityBtn2.ForeColor = System.Drawing.Color.Transparent;
            this.cityBtn2.Location = new System.Drawing.Point(116, 606);
            this.cityBtn2.Margin = new System.Windows.Forms.Padding(0);
            this.cityBtn2.Name = "cityBtn2";
            this.cityBtn2.Size = new System.Drawing.Size(64, 64);
            this.cityBtn2.TabIndex = 0;
            this.cityBtn2.UseVisualStyleBackColor = true;
            this.cityBtn2.Click += new System.EventHandler(this.cityBtn_Click);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(717, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(66, 31);
            this.title.TabIndex = 0;
            this.title.Text = "Title";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.title);
            this.titlePanel.Location = new System.Drawing.Point(308, 12);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1500, 50);
            this.titlePanel.TabIndex = 2;
            // 
            // infoPanel1
            // 
            this.infoPanel1.BackColor = System.Drawing.Color.Transparent;
            this.infoPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoPanel1.BackgroundImage")));
            this.infoPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoPanel1.Location = new System.Drawing.Point(0, 0);
            this.infoPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.infoPanel1.Name = "infoPanel1";
            this.infoPanel1.Size = new System.Drawing.Size(250, 500);
            this.infoPanel1.TabIndex = 1;
            // 
            // gamePanel1
            // 
            this.gamePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gamePanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamePanel1.Location = new System.Drawing.Point(264, 76);
            this.gamePanel1.Name = "gamePanel1";
            this.gamePanel1.Size = new System.Drawing.Size(1600, 900);
            this.gamePanel1.TabIndex = 3;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Warring_Kingdom.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.gamePanel1);
            this.Controls.Add(this.cityBtn1);
            this.Controls.Add(this.cityBtn2);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.infoPanel1);
            this.Controls.Add(this.menuBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.ShowInTaskbar = false;
            this.Text = "gameForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button cityBtn1;
        private System.Windows.Forms.Button cityBtn2;
        private InfoPanel infoPanel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel titlePanel;
        private GamePanel gamePanel1;



    }
}