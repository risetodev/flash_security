using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;
using System.Threading;
using System.IO;


namespace loginSecur
{
    public partial class Enter : Form
    {
        public string PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\FlashSecurityData\\";

        private const int WM_DEVICE_CHANGE = 0x219;
        private const int DEVICE_INSERT = 0x8000;
        private const int DEVICE_REMOVE = 0x8004;

        USBDrive USBInfo = new USBDrive("", "", "");
        List<USBDrive> USBDrivesList = new List<USBDrive>();
        USBDataBase USBInfoDB = new USBDataBase("", "", "", 0);
        List<USBDataBase> USBDataBaseList = new List<USBDataBase>();
        User user = new User("", "");
        List<User> UsersList = new List<User>();
        string selectedUSBDrive = "";
        private Main MainForm;
        private NewUser regNewUser;
        private USBEditig EditUSB;        

        public Enter()
        {
            InitializeComponent();
            hideInterface();
            getUSBListComboBox();
            GetDataBaseInList();
            HashCodeGenarator();
            if (USBDrivesList.Count == 0)
            {
                MessageBox.Show("No USB Drive detected!\nInsert the Flash-drive and then run this program!");
                CloseProgram();
            }             
            else
            {
                int buf = 0;
                foreach (var i in USBDataBaseList)
                {
                    foreach (var j in USBDrivesList)
                    {                        
                        if (i.volumeLabel == j.volumeLabel && i.totalSize == j.totalSize)
                        {
                            buf++;
                            break;
                        }
                    }
                }
                if (buf == 0)
                {
                    MessageBox.Show("This software works only with authorized Flash-drives!");
                    CloseProgram();
                }
            }            
            foreach (var i in USBDrivesList)
            {
                comboBox1.Items.Add(i.name + " " + i.volumeLabel + " " + i.totalSize);
            }            
        }

        public void CloseProgram()
        {
            try
            {
                Environment.Exit(0);
                //Application.Exit();
            }
            catch (Exception q) { MessageBox.Show(q.ToString()); return; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainForm = new Main();
            regNewUser = new NewUser();
            EditUSB = new USBEditig();
        }     
       
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                Help.ShowHelp(this, "help.chm");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Method gets the List of UsersList
        /// </summary>
        public void GetUsersListInList()
        {
            string ID = "";
            string password = "";
            var dataBase = File.ReadAllLines(PATH + "Users.txt");
            foreach (var i in dataBase)
            {
                string strBuf = i;
                int j;
                for (j = 0; j < i.Length; j++)
                {
                    if (strBuf[j] != ',')
                    {
                        ID += strBuf[j];
                    }
                    else break;
                }
                for (j = ID.Length + 1; j < i.Length; j++)
                {
                    password += strBuf[j];
                }
                UsersList.Add(new User(ID, password));
                ID = "";
                password = "";                
            }           
        }

        /// <summary>
        /// genarate a hash code based on "(i.name + " " + i.volumeLabel + " TotalSize: " + i.totalSize).ToString()" with out spaces
        /// </summary>        
        public void HashCodeGenarator()
        {
            string buf = "";
            foreach (var x in USBDrivesList)
            {
                foreach (var y in USBDataBaseList)
                {
                    if (x.volumeLabel == y.volumeLabel)
                    {
                        y.name = x.name;
                    }
                }
            }
            foreach (var i in USBDataBaseList)
            {
               buf = (i.name + " " + i.volumeLabel + " " + i.totalSize).ToString();
               buf = System.Text.RegularExpressions.Regex.Replace(buf, @"\s+", "");
               i.hashCodeOfTheUSB = buf.GetHashCode();
            }
        }

        /// <summary>
        /// Add new USB Drive in DataBase
        /// </summary>
        public void AddNewUSBDriveInDataBase()
        {
            using (StreamWriter addUSB = File.AppendText(PATH + "DataBase.txt"))
            {
                string buf = comboBox1.SelectedItem.ToString().Remove(0, 3).Trim();
                var bufArray = buf.ToCharArray();
                for (int i = 0; i < bufArray.Length; i++)
                {
                    if (bufArray[i] == ' ')
                    {
                        bufArray[i] = ',';
                    }
                }
                buf = "";
                for (int i = 0; i < bufArray.Length; i++)
                {
                    buf += bufArray[i];
                }
                buf += '|' + buf.GetHashCode().ToString();
                addUSB.WriteLine(buf);
                addUSB.Close();
            }
        }


        /// <summary>
        /// Add new USB Drive in DataBase
        /// </summary>
        public void GetDataBaseInList()
        {
            USBDataBaseList.Clear();
            string bufVolumeLabel = "";
            string bufSize = "";            
            var dataBase = File.ReadAllLines(PATH + "DataBase.txt");
            foreach (var i in dataBase)
            {               
                string strBuf = i;
                int j;
                for (j = 0; j < i.Length; j++)
                {
                    if (strBuf[j] != ',')
                    {
                        bufVolumeLabel += strBuf[j];
                    }
                    else break;                  
                }
                for (j = bufVolumeLabel.Length + 1; j < i.Length; j++)
                {
                    if (strBuf[j] != '|')
                    {
                        bufSize += strBuf[j];
                    }
                    else break;
                }                
                USBDataBaseList.Add(new USBDataBase("", bufVolumeLabel, bufSize, 0));
                bufVolumeLabel = "";
                bufSize = "";
            }            
        }

        /// <summary>
        /// get the list of installed USB Drives with help of DriveInfo class GetDrives() and checked in "Removable" status
        /// </summary>
        public void getUSBListComboBox()
        {
            USBDrivesList.Clear();
            var getUSBListComboBox = new ManagementObjectSearcher("select * from Win32_DiskDrive where InterfaceType='USB'").Get();
            foreach (var i in DriveInfo.GetDrives())
            {
                if (i.DriveType.ToString() == "Removable")
                {
                    USBDrivesList.Add(new USBDrive(i.Name, i.VolumeLabel, i.TotalSize.ToString()));
                }
            }            
        }

        void showInterface()
        {
            this.AcceptButton = EnterInSys;
            ID.Visible = true;
            Password.Visible = true;
            idBox.Visible = true;
            passwordBox.Visible = true;
            EnterInSys.Visible = true;
        }

        void hideInterface()
        {
            this.AcceptButton = checkButton;
            ID.Visible = false;
            Password.Visible = false;
            idBox.Visible = false;
            passwordBox.Visible = false;
            EnterInSys.Visible = false;
            idBox.Clear();
            passwordBox.Clear();
        }

        /// <summary>
        /// looking for moment of inserting the USB Drive
        /// </summary>        
        protected override void WndProc(ref Message m)
        {
            Thread DeviceQuery = new Thread(getUSBListComboBox);
            base.WndProc(ref m);
            switch (m.Msg)
            {
            case WM_DEVICE_CHANGE:
                    {
                        switch ((int)m.WParam)
                        {
                            case DEVICE_INSERT:
                                {                                  
                                    hideInterface();
                                    comboBox1.Items.Clear();
                                    DeviceQuery.Start();
                                    Thread.Sleep(500);
                                    foreach (var i in USBDrivesList)
                                    {
                                        comboBox1.Items.Add(i.name + " " + i.volumeLabel + " " + i.totalSize);
                                    }
                                    DeviceQuery.Abort();
                                    break;
                                }
                            case DEVICE_REMOVE:
                                {
                                    hideInterface();
                                    comboBox1.Items.Clear();
                                    DeviceQuery.Start();
                                    Thread.Sleep(500);
                                    foreach (var i in USBDrivesList)
                                    {
                                        comboBox1.Items.Add(i.name + " " + i.volumeLabel + " " + i.totalSize);
                                    }
                                    DeviceQuery.Abort();
                                    break;
                                }
                        }
                        break;

                    }
            }
        }      
                
        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// "ENTER" button is checking id and password
        /// </summary>       
        private void EnterInSys_Click(object sender, EventArgs e)
        {
            GetUsersListInList();
            selectUSBDrive();
            int buf = 0;
            if (idBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Something you missed!");
                return;
            }
            else
            {
                foreach (var i in UsersList)
                {
                    if (i.ID.Substring(1) == idBox.Text && i.Password == passwordBox.Text.GetHashCode().ToString())
                    {
                        if (i.ID[0] == 'A')
                        {
                            MainForm.showAdminRights();
                        }
                        else if (i.ID[0] == 'U')
                        {                           
                            MainForm.hideAdminRights();                            
                        }
                        //MainForm.passwordCheck = passwordBox.Text;
                        this.Hide();
                        MainForm.ShowDialog();
                        this.Show();
                        hideInterface();
                    }                   
                    else buf++;
                }               
                if (UsersList.Count == buf)
                {
                    MessageBox.Show("ID or password is wrong or selected USB Drive is wrong!");
                    return;
                }
            }           
        }
               
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public string Path = "";
        /// <summary>
        /// Method for adding USB Drives in a list(comboBox1) and add new in DataBase
        /// </summary>
        void selectUSBDrive()
        {
            int buf = 0;
           // GetDataBaseInList();            
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Choose the USB Drive!");
                return;
            }
            else
            {   
                foreach (var i in USBDataBaseList)
                {
                    selectedUSBDrive = comboBox1.SelectedItem.ToString();
                    selectedUSBDrive = System.Text.RegularExpressions.Regex.Replace(selectedUSBDrive, @"\s+", "");
                    if (i.hashCodeOfTheUSB == selectedUSBDrive.GetHashCode())
                    {
                        showInterface();                         
                        MainForm.webBrowser1.Url = new Uri(i.name);
                        Path = i.name;
                        break;
                    }
                    else buf++;
                }
            }
            if (USBDataBaseList.Count == buf)
            {
                MessageBox.Show("Incorrect USB Drive!");
                return;
            } 
        }

        private void checkButton_Click(object sender, EventArgs e)
        {           
            hideInterface();
            GetDataBaseInList();
            HashCodeGenarator();
            selectUSBDrive();            
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void AddNewUSBDrive_Click(object sender, EventArgs e)
        {
           

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void help_button_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm");
        }
    }
}
