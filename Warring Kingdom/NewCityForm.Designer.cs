namespace Warring_Kingdom
{
    partial class NewCityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCityForm));
            this.newCityTitle = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newCityTitle
            // 
            this.newCityTitle.BackColor = System.Drawing.Color.Transparent;
            this.newCityTitle.Font = new System.Drawing.Font("Snap ITC", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCityTitle.ForeColor = System.Drawing.Color.Tomato;
            this.newCityTitle.Image = ((System.Drawing.Image)(resources.GetObject("newCityTitle.Image")));
            this.newCityTitle.Location = new System.Drawing.Point(-26, 0);
            this.newCityTitle.Name = "newCityTitle";
            this.newCityTitle.Size = new System.Drawing.Size(529, 58);
            this.newCityTitle.TabIndex = 11;
            this.newCityTitle.Text = "                                   ";
            // 
            // cityBox
            // 
            this.cityBox.BackColor = System.Drawing.SystemColors.Control;
            this.cityBox.Location = new System.Drawing.Point(249, 78);
            this.cityBox.MaxLength = 16;
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(120, 20);
            this.cityBox.TabIndex = 12;
            // 
            // cityLabel
            // 
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cityLabel.ForeColor = System.Drawing.Color.Lime;
            this.cityLabel.Image = ((System.Drawing.Image)(resources.GetObject("cityLabel.Image")));
            this.cityLabel.Location = new System.Drawing.Point(102, 79);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(127, 34);
            this.cityLabel.TabIndex = 14;
            this.cityLabel.Text = "                   ";
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConfirmBtn.BackgroundImage")));
            this.ConfirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmBtn.FlatAppearance.BorderSize = 0;
            this.ConfirmBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ConfirmBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmBtn.ForeColor = System.Drawing.Color.Gold;
            this.ConfirmBtn.Location = new System.Drawing.Point(188, 116);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(91, 33);
            this.ConfirmBtn.TabIndex = 15;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // NewCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Warring_Kingdom.Properties.Resources.reg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 162);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.newCityTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "NewCityForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New City";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newCityTitle;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}