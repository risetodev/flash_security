using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Ionic.Zip;
using System.Threading;
using System.Security.Cryptography;
using System.Text.RegularExpressions;


namespace loginSecur
{
    public partial class Main : Form
    {
        private Enter EnterForm;
        private NewUser regNewUser;
        private USBEditig editUSBs;
        List<User> USERS = new List<User>();
        

        public Main()
        {            
            InitializeComponent();              
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            EnterForm = new Enter();
            regNewUser = new NewUser();
            editUSBs = new USBEditig();
        }
        
        /// <summary>
        /// Abort the programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emergencyExit_Click(object sender, EventArgs e)
        {
            try
            {
                Environment.Exit(0);
                //Application.Exit();
            }
            catch (Exception i) { MessageBox.Show(i.ToString()); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                      
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack) webBrowser1.GoBack();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward) webBrowser1.GoForward();
        }

        private void path_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }     
        
        /// <summary>
        /// Makes admin right visible
        /// </summary>
        public void showAdminRights()
        {
            AdminLabel.Visible = true;
            AdminRightsLabel.Visible = true;
            EditUSBDrives.Visible = true;
            EditUsers.Visible = true;
        }
        private void AdminLabel_Click(object sender, EventArgs e)
        {

        }

        private void AdminRightsLabel_Click(object sender, EventArgs e)
        {

        }

        private void EditUSBDrives_Click(object sender, EventArgs e)
        {
            editUSBs.ShowDialog();
            this.Show();
        }

        private void EditUsers_Click(object sender, EventArgs e)
        {
            regNewUser.ShowDialog();
            this.Show();
        }

        public string passwordCheck { get; set; }

        /// <summary>
        /// Zip and encrypt archive
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                labelCompressionStatus.Visible = true;
                progressBarEncryption1.Visible = true;
                string DirectoryToZip = webBrowser1.Url.ToString().Substring(8);
                string ZipFileToCreate = (webBrowser1.Url.ToString() + "archive.zip").Substring(8);
                using (ZipFile zip = new ZipFile())
                {
                    zip.SaveProgress += saveProgress;
                    zip.UseUnicodeAsNecessary = true;
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                    zip.Password = passwordCheck;
                    zip.Encryption = EncryptionAlgorithm.WinZipAes256;
                    zip.AddDirectory(DirectoryToZip);
                    zip.Save(ZipFileToCreate);
                    ////////////////////////////////////////////////////////////////////s//Delete filse except archive.zip
                    System.IO.DirectoryInfo dir = new DirectoryInfo(DirectoryToZip);
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        if (file.Name != "archive.zip")
                            file.Delete();
                    }
                    foreach (DirectoryInfo di in dir.GetDirectories())
                    {
                        di.Delete(true);
                    }
                    MessageBox.Show("Done! Successfully encrypted!");
                }
            }
            catch (Exception i) { MessageBox.Show(i.ToString()); return; }           
        }

        /// <summary>
        /// ProgressBar for the encryption 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void saveProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Saving_EntryBytesRead)
            {
                progressBarEncryption1.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
            }           
            else if (e.EventType == ZipProgressEventType.Saving_Completed)
            {              
                 progressBarEncryption1.Value = 0;
                 progressBarEncryption1.Visible = false;
                 labelCompressionStatus.Visible = false;
            }
        }        

        /// <summary>
        ///  Unzip and decrypt archive
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string password = ShowDialog("ID's password ", "Confirmation");
                if (password == passwordCheck)
                {
                    labelCompressionStatus.Visible = true;
                    progressBarEncryption1.Visible = true;
                    string startPath = webBrowser1.Url.ToString().Substring(8);
                    string archivePath = (webBrowser1.Url.ToString() + "archive.zip").Substring(8);
                    using (var zip = ZipFile.Read(archivePath))
                    {
                        zip.ExtractProgress += extractProgress;
                        //zip.UseUnicodeAsNecessary = true;
                        //zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                        zip.Password = password;
                        //zip.Encryption = EncryptionAlgorithm.WinZipAes256;
                        var selection = from i in zip.Entries select i;
                        foreach (var i in selection)
                            i.Extract(startPath);
                    }
                    System.IO.DirectoryInfo dir = new DirectoryInfo(startPath);
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        if (file.Name == "archive.zip")
                            file.Delete();
                    }
                    progressBarEncryption1.Value = 0;
                    progressBarEncryption1.Visible = false;
                    labelCompressionStatus.Visible = false;
                    MessageBox.Show("Done! Successfully decrypted!");
                }
                else if(password == "esc")
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Error! Invalid password!");
                    return;
                }
            } catch (Exception i) { MessageBox.Show(i.ToString()); return; }          
        }

        /// <summary>
        ///  ProgressBar for the decryption 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void extractProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.TotalBytesToTransfer > 0)
            {
                progressBarEncryption1.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
            }
        }

        /// <summary>
        /// Dialog for asking the password
        /// </summary>
        /// <param name="text"></param>
        /// <param name="caption"></param>
        /// <returns></returns>
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                StartPosition = FormStartPosition.CenterScreen
            };
            prompt.Width = 510;
            prompt.Height = 150;
            prompt.Text = caption;
            prompt.ControlBox = false;            
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Submit", Left = 350, Width = 100, Top = 70 };
            Button cancel = new Button() { Text = "Cancel", Left = 250, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancel.Click += (sender, e) => { textBox.Text = "esc"; prompt.Close(); };
            textBox.PasswordChar = '*';
            textBox.Focus();            
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.ShowDialog();
            return textBox.Text.ToString();
        }



        private void progressBarEncryption1_Click(object sender, EventArgs e)
        {

        }
         

        private void labelCompressionStatus_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Format the hole USB Drive
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formatDiskButton_Click(object sender, EventArgs e)
        {
            try
            {/*
                string startPath = webBrowser1.Url.ToString().Substring(8);
                DirectoryInfo dir = new DirectoryInfo(startPath);
                ////////////////////////////////////////////////////////////////////s//Delete filse except archive.zip
                foreach (FileInfo file in dir.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo di in dir.GetDirectories())
                {
                    di.Delete(true);
                }
                MessageBox.Show("Successfully formatted!");*/
                progressBarEncryption1.Visible = true;              
                int maxValue = 0, x = 0;
                string startPath = webBrowser1.Url.ToString().Substring(8);
                DirectoryInfo dir = new DirectoryInfo(startPath);
                //////////////////////////////////////////////////////////////////////Delete filse except archive.zip
                foreach (FileInfo file in dir.GetFiles())
                {
                    maxValue++;
                }
                foreach (DirectoryInfo di in dir.GetDirectories())
                {
                    maxValue++;
                }

                progressBarEncryption1.Value = (int)((x / maxValue) * 100);
                foreach (FileInfo file in dir.GetFiles())
                {
                    x++;
                    file.Delete();
                    progressBarEncryption1.Value = (int)((x / maxValue) * 100);
                }
                foreach (DirectoryInfo di in dir.GetDirectories())
                {
                    x++;
                    di.Delete(true);
                    progressBarEncryption1.Value = (int)((x / maxValue) * 100);
                }                
                MessageBox.Show("Successfully formatted!");
                progressBarEncryption1.Visible = false;
                progressBarEncryption1.Value = 0;
                return;
            } catch (Exception i) { MessageBox.Show(i.ToString()); return; }           
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm");
        }
    }
}
