namespace loginSecur
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.firstPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.secondPassword = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chooseUserToDelete = new System.Windows.Forms.ComboBox();
            this.DeleteFromDBButton = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter User\'s ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create password:";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(180, 45);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(310, 30);
            this.ID.TabIndex = 2;
            this.ID.TextChanged += new System.EventHandler(this.firstPassword_TextChanged);
            // 
            // firstPassword
            // 
            this.firstPassword.Location = new System.Drawing.Point(180, 88);
            this.firstPassword.Name = "firstPassword";
            this.firstPassword.PasswordChar = '*';
            this.firstPassword.Size = new System.Drawing.Size(310, 30);
            this.firstPassword.TabIndex = 3;
            this.firstPassword.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm password:";
            // 
            // secondPassword
            // 
            this.secondPassword.Location = new System.Drawing.Point(180, 132);
            this.secondPassword.Name = "secondPassword";
            this.secondPassword.PasswordChar = '*';
            this.secondPassword.Size = new System.Drawing.Size(310, 30);
            this.secondPassword.TabIndex = 5;
            this.secondPassword.TextChanged += new System.EventHandler(this.secondPassword_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(340, 168);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(150, 31);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submit_Click);
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAdmin.Location = new System.Drawing.Point(180, 168);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(83, 26);
            this.radioButtonAdmin.TabIndex = 7;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = false;
            this.radioButtonAdmin.CheckedChanged += new System.EventHandler(this.radioButtonAdmin_CheckedChanged);
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonUser.Location = new System.Drawing.Point(269, 168);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(65, 26);
            this.radioButtonUser.TabIndex = 8;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "User";
            this.radioButtonUser.UseVisualStyleBackColor = false;
            this.radioButtonUser.CheckedChanged += new System.EventHandler(this.radioButtonUser_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Authorize User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Delete User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Choose User:";
            // 
            // chooseUserToDelete
            // 
            this.chooseUserToDelete.FormattingEnabled = true;
            this.chooseUserToDelete.Location = new System.Drawing.Point(12, 266);
            this.chooseUserToDelete.Name = "chooseUserToDelete";
            this.chooseUserToDelete.Size = new System.Drawing.Size(478, 30);
            this.chooseUserToDelete.TabIndex = 12;
            this.chooseUserToDelete.SelectedIndexChanged += new System.EventHandler(this.chooseUserToDelete_SelectedIndexChanged);
            // 
            // DeleteFromDBButton
            // 
            this.DeleteFromDBButton.Location = new System.Drawing.Point(290, 302);
            this.DeleteFromDBButton.Name = "DeleteFromDBButton";
            this.DeleteFromDBButton.Size = new System.Drawing.Size(200, 31);
            this.DeleteFromDBButton.TabIndex = 13;
            this.DeleteFromDBButton.Text = "Delete form Database";
            this.DeleteFromDBButton.UseVisualStyleBackColor = true;
            this.DeleteFromDBButton.Click += new System.EventHandler(this.DeleteFromDBButton_Click);
            // 
            // help_button
            // 
            this.help_button.Location = new System.Drawing.Point(434, 5);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(56, 34);
            this.help_button.TabIndex = 25;
            this.help_button.Text = "Help";
            this.help_button.UseVisualStyleBackColor = true;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(502, 415);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.DeleteFromDBButton);
            this.Controls.Add(this.chooseUserToDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButtonUser);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.secondPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstPassword);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Authorize User | Delete User";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox firstPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox secondPassword;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox chooseUserToDelete;
        private System.Windows.Forms.Button DeleteFromDBButton;
        private System.Windows.Forms.Button help_button;
    }
}