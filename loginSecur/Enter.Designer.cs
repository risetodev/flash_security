namespace loginSecur
{
    partial class Enter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter));
            this.ID = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.EnterInSys = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.selectUSBLabel = new System.Windows.Forms.Label();
            this.help_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(1, 13);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(76, 22);
            this.ID.TabIndex = 0;
            this.ID.Text = "Your ID:";
            this.ID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ID.Visible = false;
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(1, 49);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(95, 22);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password:";
            this.Password.Visible = false;
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // EnterInSys
            // 
            this.EnterInSys.BackColor = System.Drawing.Color.Transparent;
            this.EnterInSys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnterInSys.ForeColor = System.Drawing.Color.Black;
            this.EnterInSys.Location = new System.Drawing.Point(398, 82);
            this.EnterInSys.Name = "EnterInSys";
            this.EnterInSys.Size = new System.Drawing.Size(70, 34);
            this.EnterInSys.TabIndex = 2;
            this.EnterInSys.Text = "Enter";
            this.EnterInSys.UseVisualStyleBackColor = false;
            this.EnterInSys.Visible = false;
            this.EnterInSys.Click += new System.EventHandler(this.EnterInSys_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(462, 30);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(398, 159);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(70, 36);
            this.checkButton.TabIndex = 8;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(97, 10);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(371, 30);
            this.idBox.TabIndex = 10;
            this.idBox.Visible = false;
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(97, 46);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(371, 30);
            this.passwordBox.TabIndex = 11;
            this.passwordBox.Visible = false;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // selectUSBLabel
            // 
            this.selectUSBLabel.AutoSize = true;
            this.selectUSBLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectUSBLabel.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectUSBLabel.ForeColor = System.Drawing.Color.White;
            this.selectUSBLabel.Location = new System.Drawing.Point(1, 173);
            this.selectUSBLabel.Name = "selectUSBLabel";
            this.selectUSBLabel.Size = new System.Drawing.Size(154, 22);
            this.selectUSBLabel.TabIndex = 12;
            this.selectUSBLabel.Text = "Select USB Drive:";
            // 
            // help_button
            // 
            this.help_button.Location = new System.Drawing.Point(5, 139);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(56, 31);
            this.help_button.TabIndex = 13;
            this.help_button.Text = "Help";
            this.help_button.UseVisualStyleBackColor = true;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // Enter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 241);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.selectUSBLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.EnterInSys);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Enter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verification";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox idBox;
        public System.Windows.Forms.Button checkButton;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label ID;
        public System.Windows.Forms.Label Password;
        public System.Windows.Forms.Button EnterInSys;
        public System.Windows.Forms.TextBox passwordBox;
        public System.Windows.Forms.Label selectUSBLabel;
        private System.Windows.Forms.Button help_button;
    }
}

