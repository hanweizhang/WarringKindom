namespace Warring_Kingdom
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.usrBox = new System.Windows.Forms.TextBox();
            this.usrLabel = new System.Windows.Forms.Label();
            this.pwdBox1 = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.pwdLabel1 = new System.Windows.Forms.Label();
            this.pwdLabel2 = new System.Windows.Forms.Label();
            this.pwdBox2 = new System.Windows.Forms.TextBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.loginTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usrBox
            // 
            this.usrBox.BackColor = System.Drawing.SystemColors.Control;
            this.usrBox.Location = new System.Drawing.Point(230, 142);
            this.usrBox.MaxLength = 16;
            this.usrBox.Name = "usrBox";
            this.usrBox.Size = new System.Drawing.Size(120, 20);
            this.usrBox.TabIndex = 0;
            // 
            // usrLabel
            // 
            this.usrLabel.AutoSize = true;
            this.usrLabel.BackColor = System.Drawing.Color.Transparent;
            this.usrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.usrLabel.ForeColor = System.Drawing.Color.Lime;
            this.usrLabel.Location = new System.Drawing.Point(133, 143);
            this.usrLabel.Name = "usrLabel";
            this.usrLabel.Size = new System.Drawing.Size(91, 17);
            this.usrLabel.TabIndex = 6;
            this.usrLabel.Text = "Username: ";
            // 
            // pwdBox1
            // 
            this.pwdBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pwdBox1.Location = new System.Drawing.Point(230, 194);
            this.pwdBox1.MaxLength = 16;
            this.pwdBox1.Name = "pwdBox1";
            this.pwdBox1.Size = new System.Drawing.Size(120, 20);
            this.pwdBox1.TabIndex = 2;
            this.pwdBox1.UseSystemPasswordChar = true;
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.SystemColors.Control;
            this.emailBox.Location = new System.Drawing.Point(230, 168);
            this.emailBox.MaxLength = 16;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(120, 20);
            this.emailBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.emailLabel.ForeColor = System.Drawing.Color.Lime;
            this.emailLabel.Location = new System.Drawing.Point(167, 169);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(57, 17);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email: ";
            // 
            // pwdLabel1
            // 
            this.pwdLabel1.AutoSize = true;
            this.pwdLabel1.BackColor = System.Drawing.Color.Transparent;
            this.pwdLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdLabel1.ForeColor = System.Drawing.Color.Lime;
            this.pwdLabel1.Location = new System.Drawing.Point(137, 195);
            this.pwdLabel1.Name = "pwdLabel1";
            this.pwdLabel1.Size = new System.Drawing.Size(87, 17);
            this.pwdLabel1.TabIndex = 8;
            this.pwdLabel1.Text = "Password: ";
            // 
            // pwdLabel2
            // 
            this.pwdLabel2.AutoSize = true;
            this.pwdLabel2.BackColor = System.Drawing.Color.Transparent;
            this.pwdLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdLabel2.ForeColor = System.Drawing.Color.Lime;
            this.pwdLabel2.Location = new System.Drawing.Point(77, 221);
            this.pwdLabel2.Name = "pwdLabel2";
            this.pwdLabel2.Size = new System.Drawing.Size(147, 17);
            this.pwdLabel2.TabIndex = 9;
            this.pwdLabel2.Text = "Confirm Password: ";
            // 
            // pwdBox2
            // 
            this.pwdBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pwdBox2.Location = new System.Drawing.Point(230, 220);
            this.pwdBox2.MaxLength = 16;
            this.pwdBox2.Name = "pwdBox2";
            this.pwdBox2.Size = new System.Drawing.Size(120, 20);
            this.pwdBox2.TabIndex = 3;
            this.pwdBox2.UseSystemPasswordChar = true;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmBtn.BackgroundImage = global::Warring_Kingdom.Properties.Resources.button;
            this.ConfirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmBtn.FlatAppearance.BorderSize = 0;
            this.ConfirmBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ConfirmBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmBtn.Location = new System.Drawing.Point(202, 268);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(80, 30);
            this.ConfirmBtn.TabIndex = 4;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.BackColor = System.Drawing.Color.Transparent;
            this.loginTitle.Font = new System.Drawing.Font("Snap ITC", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.ForeColor = System.Drawing.Color.Tomato;
            this.loginTitle.Location = new System.Drawing.Point(73, 29);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(218, 39);
            this.loginTitle.TabIndex = 10;
            this.loginTitle.Text = "Welcome to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(119, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "Warring Kingdom";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTitle);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.pwdBox2);
            this.Controls.Add(this.pwdLabel2);
            this.Controls.Add(this.pwdLabel1);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.pwdBox1);
            this.Controls.Add(this.usrLabel);
            this.Controls.Add(this.usrBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "RegForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usrBox;
        private System.Windows.Forms.Label usrLabel;
        private System.Windows.Forms.TextBox pwdBox1;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label pwdLabel1;
        private System.Windows.Forms.Label pwdLabel2;
        private System.Windows.Forms.TextBox pwdBox2;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Label label1;
    }
}