namespace Warring_Kingdom
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.usrLabel = new System.Windows.Forms.Label();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.usrBox = new System.Windows.Forms.TextBox();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.loginTitle = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.regLink = new System.Windows.Forms.Button();
            this.authorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usrLabel
            // 
            this.usrLabel.BackColor = System.Drawing.Color.Transparent;
            this.usrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.usrLabel.ForeColor = System.Drawing.Color.Lime;
            this.usrLabel.Image = ((System.Drawing.Image)(resources.GetObject("usrLabel.Image")));
            this.usrLabel.Location = new System.Drawing.Point(133, 167);
            this.usrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usrLabel.Name = "usrLabel";
            this.usrLabel.Size = new System.Drawing.Size(152, 45);
            this.usrLabel.TabIndex = 0;
            this.usrLabel.Text = "                             ";
            // 
            // pwdLabel
            // 
            this.pwdLabel.BackColor = System.Drawing.Color.Transparent;
            this.pwdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdLabel.ForeColor = System.Drawing.Color.LightYellow;
            this.pwdLabel.Image = ((System.Drawing.Image)(resources.GetObject("pwdLabel.Image")));
            this.pwdLabel.Location = new System.Drawing.Point(147, 212);
            this.pwdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(129, 51);
            this.pwdLabel.TabIndex = 1;
            this.pwdLabel.Text = "                           ";
            // 
            // usrBox
            // 
            this.usrBox.BackColor = System.Drawing.SystemColors.Control;
            this.usrBox.Location = new System.Drawing.Point(284, 167);
            this.usrBox.Margin = new System.Windows.Forms.Padding(4);
            this.usrBox.MaxLength = 16;
            this.usrBox.Name = "usrBox";
            this.usrBox.Size = new System.Drawing.Size(159, 22);
            this.usrBox.TabIndex = 2;
            // 
            // pwdBox
            // 
            this.pwdBox.BackColor = System.Drawing.SystemColors.Control;
            this.pwdBox.Location = new System.Drawing.Point(284, 213);
            this.pwdBox.Margin = new System.Windows.Forms.Padding(4);
            this.pwdBox.MaxLength = 16;
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.Size = new System.Drawing.Size(159, 22);
            this.pwdBox.TabIndex = 3;
            this.pwdBox.UseSystemPasswordChar = true;
            // 
            // loginTitle
            // 
            this.loginTitle.BackColor = System.Drawing.Color.Transparent;
            this.loginTitle.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.loginTitle.Image = ((System.Drawing.Image)(resources.GetObject("loginTitle.Image")));
            this.loginTitle.Location = new System.Drawing.Point(-14, 44);
            this.loginTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(677, 61);
            this.loginTitle.TabIndex = 4;
            this.loginTitle.Text = "                          ";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.BackgroundImage")));
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginBtn.ForeColor = System.Drawing.Color.Gold;
            this.LoginBtn.Location = new System.Drawing.Point(319, 269);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(108, 47);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // regLink
            // 
            this.regLink.BackColor = System.Drawing.Color.Transparent;
            this.regLink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regLink.BackgroundImage")));
            this.regLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regLink.Enabled = false;
            this.regLink.FlatAppearance.BorderSize = 0;
            this.regLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.regLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.regLink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.regLink.ForeColor = System.Drawing.Color.Gold;
            this.regLink.Location = new System.Drawing.Point(182, 269);
            this.regLink.Margin = new System.Windows.Forms.Padding(4);
            this.regLink.Name = "regLink";
            this.regLink.Size = new System.Drawing.Size(116, 47);
            this.regLink.TabIndex = 4;
            this.regLink.Text = "Register";
            this.regLink.UseVisualStyleBackColor = false;
            this.regLink.UseWaitCursor = true;
            this.regLink.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.authorLabel.ForeColor = System.Drawing.Color.White;
            this.authorLabel.Location = new System.Drawing.Point(273, 417);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(339, 17);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "- by Hanwei Zhang, Jiaqi Liu, and Noah Miller";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Warring_Kingdom.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 436);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.regLink);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.loginTitle);
            this.Controls.Add(this.pwdBox);
            this.Controls.Add(this.usrBox);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.usrLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(661, 481);
            this.MinimumSize = new System.Drawing.Size(661, 481);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usrLabel;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.TextBox usrBox;
        private System.Windows.Forms.TextBox pwdBox;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button regLink;
        private System.Windows.Forms.Label authorLabel;
    }
}

