namespace loginSecur
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.emergencyExit = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.EditUSBDrives = new System.Windows.Forms.Button();
            this.EditUsers = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.formatDiskButton = new System.Windows.Forms.Button();
            this.AdminRightsLabel = new System.Windows.Forms.Label();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.progressBarEncryption1 = new System.Windows.Forms.ProgressBar();
            this.labelCompressionStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emergencyExit
            // 
            this.emergencyExit.BackColor = System.Drawing.Color.Transparent;
            this.emergencyExit.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emergencyExit.ForeColor = System.Drawing.Color.Red;
            this.emergencyExit.Location = new System.Drawing.Point(731, 10);
            this.emergencyExit.Margin = new System.Windows.Forms.Padding(5);
            this.emergencyExit.Name = "emergencyExit";
            this.emergencyExit.Size = new System.Drawing.Size(261, 39);
            this.emergencyExit.TabIndex = 0;
            this.emergencyExit.Text = "EMERGENCY SHUTDOWN";
            this.emergencyExit.UseVisualStyleBackColor = false;
            this.emergencyExit.Click += new System.EventHandler(this.emergencyExit_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 57);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(980, 320);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(76, 39);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.BackColor = System.Drawing.Color.Transparent;
            this.buttonForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonForward.BackgroundImage")));
            this.buttonForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonForward.Location = new System.Drawing.Point(94, 12);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(79, 39);
            this.buttonForward.TabIndex = 3;
            this.buttonForward.UseVisualStyleBackColor = false;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // EditUSBDrives
            // 
            this.EditUSBDrives.Location = new System.Drawing.Point(586, 608);
            this.EditUSBDrives.Name = "EditUSBDrives";
            this.EditUSBDrives.Size = new System.Drawing.Size(246, 39);
            this.EditUSBDrives.TabIndex = 4;
            this.EditUSBDrives.Text = "Authorize USB | Delete USB";
            this.EditUSBDrives.UseVisualStyleBackColor = true;
            this.EditUSBDrives.Visible = false;
            this.EditUSBDrives.Click += new System.EventHandler(this.EditUSBDrives_Click);
            // 
            // EditUsers
            // 
            this.EditUsers.Location = new System.Drawing.Point(123, 608);
            this.EditUsers.Name = "EditUsers";
            this.EditUsers.Size = new System.Drawing.Size(246, 40);
            this.EditUsers.TabIndex = 5;
            this.EditUsers.Text = "Authorize User | Delete User";
            this.EditUsers.UseVisualStyleBackColor = true;
            this.EditUsers.Visible = false;
            this.EditUsers.Click += new System.EventHandler(this.EditUsers_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(901, 383);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(92, 39);
            this.EncryptButton.TabIndex = 6;
            this.EncryptButton.Text = "Encrypt*";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(804, 383);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(91, 39);
            this.DecryptButton.TabIndex = 7;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // formatDiskButton
            // 
            this.formatDiskButton.BackColor = System.Drawing.Color.Transparent;
            this.formatDiskButton.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formatDiskButton.ForeColor = System.Drawing.Color.Red;
            this.formatDiskButton.Location = new System.Drawing.Point(369, 10);
            this.formatDiskButton.Name = "formatDiskButton";
            this.formatDiskButton.Size = new System.Drawing.Size(220, 39);
            this.formatDiskButton.TabIndex = 8;
            this.formatDiskButton.Text = "FORMAT the USB Drive";
            this.formatDiskButton.UseVisualStyleBackColor = false;
            this.formatDiskButton.Click += new System.EventHandler(this.formatDiskButton_Click);
            // 
            // AdminRightsLabel
            // 
            this.AdminRightsLabel.AutoSize = true;
            this.AdminRightsLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdminRightsLabel.ForeColor = System.Drawing.Color.Black;
            this.AdminRightsLabel.Location = new System.Drawing.Point(382, 616);
            this.AdminRightsLabel.Name = "AdminRightsLabel";
            this.AdminRightsLabel.Size = new System.Drawing.Size(189, 22);
            this.AdminRightsLabel.TabIndex = 11;
            this.AdminRightsLabel.Text = "<<< Admin rights >>>";
            this.AdminRightsLabel.Visible = false;
            this.AdminRightsLabel.Click += new System.EventHandler(this.AdminRightsLabel_Click);
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdminLabel.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminLabel.ForeColor = System.Drawing.Color.Lime;
            this.AdminLabel.Location = new System.Drawing.Point(7, 574);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(227, 64);
            this.AdminLabel.TabIndex = 13;
            this.AdminLabel.Text = "ADMINISTRATOR \r\nVERSION";
            this.AdminLabel.Visible = false;
            this.AdminLabel.Click += new System.EventHandler(this.AdminLabel_Click);
            // 
            // progressBarEncryption1
            // 
            this.progressBarEncryption1.Location = new System.Drawing.Point(13, 448);
            this.progressBarEncryption1.Name = "progressBarEncryption1";
            this.progressBarEncryption1.Size = new System.Drawing.Size(980, 24);
            this.progressBarEncryption1.TabIndex = 14;
            this.progressBarEncryption1.Visible = false;
            this.progressBarEncryption1.Click += new System.EventHandler(this.progressBarEncryption1_Click);
            // 
            // labelCompressionStatus
            // 
            this.labelCompressionStatus.AutoSize = true;
            this.labelCompressionStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelCompressionStatus.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompressionStatus.ForeColor = System.Drawing.Color.Lime;
            this.labelCompressionStatus.Location = new System.Drawing.Point(8, 423);
            this.labelCompressionStatus.Name = "labelCompressionStatus";
            this.labelCompressionStatus.Size = new System.Drawing.Size(79, 22);
            this.labelCompressionStatus.TabIndex = 21;
            this.labelCompressionStatus.Text = "Process:";
            this.labelCompressionStatus.Visible = false;
            this.labelCompressionStatus.Click += new System.EventHandler(this.labelCompressionStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(705, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "* - encryption with your password";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 677);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditUsers);
            this.Controls.Add(this.labelCompressionStatus);
            this.Controls.Add(this.progressBarEncryption1);
            this.Controls.Add(this.AdminLabel);
            this.Controls.Add(this.AdminRightsLabel);
            this.Controls.Add(this.formatDiskButton);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.EditUSBDrives);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.emergencyExit);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button emergencyExit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button EditUSBDrives;
        private System.Windows.Forms.Button EditUsers;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button formatDiskButton;
        private System.Windows.Forms.Label AdminRightsLabel;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.ProgressBar progressBarEncryption1;
        private System.Windows.Forms.Label labelCompressionStatus;
        private System.Windows.Forms.Label label1;
    }
}