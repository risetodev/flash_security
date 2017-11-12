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
using System.Security.Cryptography;

namespace loginSecur
{
    public partial class NewUser : Form
    {
        private Main regNewUser;        
        List<User> UsersList = new List<User>();

        public NewUser()
        {
            InitializeComponent();
            GetUsersListInList();
            refreshUsersCombobox();
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
        void GetUsersListInList()
        {
            UsersList.Clear();
            string ID = "";
            string password = "";
            var dataBase = File.ReadAllLines("Users.txt");
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

   

        private void NewUser_Load(object sender, EventArgs e)
        {
            regNewUser = new Main();
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            bool similarUsersList = false, isTheSame = false;
            GetUsersListInList();
            if (ID.Text == "" || firstPassword.Text == "" || secondPassword.Text == "")
            {
                MessageBox.Show("Fill the empty fields!");
                return;
            }
            else
            {
                foreach (var i in UsersList)
                {
                    if (ID.Text == i.ID.Substring(1))
                    {
                        similarUsersList = true;
                    }
                }
                foreach (var i in UsersList)
                {
                    if (firstPassword.Text != secondPassword.Text)
                    {
                        isTheSame = false;
                    }
                    else isTheSame = true;
                }
                if (similarUsersList == true)
                {
                    ID.Clear();
                    firstPassword.Clear();
                    secondPassword.Clear();
                    radioButtonAdmin.Checked = false;
                    radioButtonUser.Checked = false;
                    refreshUsersCombobox();
                    MessageBox.Show("User already exist!");
                }
                else if (isTheSame == false)
                {
                    firstPassword.Clear();
                    secondPassword.Clear();
                    MessageBox.Show("The passwords didn't match!");
                }
                else if (similarUsersList == false && isTheSame == true && (radioButtonAdmin.Checked == true || radioButtonUser.Checked == true))
                {
                    using (StreamWriter NewUserInDB = File.AppendText("Users.txt"))
                    {
                        string buf = "";
                        if (radioButtonAdmin.Checked)
                        {
                            buf += 'A' + ID.Text;
                        }
                        else if (radioButtonUser.Checked)
                        {
                            buf += 'U' + ID.Text;
                        }
                        buf += ",";
                        buf += secondPassword.Text;
                        NewUserInDB.WriteLine(buf);
                        NewUserInDB.Close();                        
                        NewUserInDB.Close();
                        ID.Clear();
                        firstPassword.Clear();
                        secondPassword.Clear();
                        radioButtonAdmin.Checked = false;
                        radioButtonUser.Checked = false;
                        refreshUsersCombobox();
                        MessageBox.Show("Done! User successfully added!");
                        return;
                    }
                }
                else MessageBox.Show("Choose the type of the User!");
            }
        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chooseUserToDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method is just refresh combobox
        /// </summary>
        void refreshUsersCombobox()
        {
            chooseUserToDelete.Items.Clear();
            GetUsersListInList();
            foreach (var i in UsersList)
            {
                chooseUserToDelete.Items.Add(i.ID.Substring(1));
            }
        }

        private void DeleteFromDBButton_Click(object sender, EventArgs e)
        {            
            if (chooseUserToDelete.SelectedItem == null)
            {
                MessageBox.Show("Choose the USB Drive!");
                return;
            }
            var dataBase = File.ReadAllLines("Users.txt");
            File.WriteAllText("Users.txt", string.Empty);
            foreach (var i in dataBase)
            {
                string ID = "";
                for (int j = 1; j < i.Length; j++)
                {
                    if (i[j] != ',')
                    {
                        ID += i[j];
                    }
                    else break;
                }               
                if (chooseUserToDelete.SelectedItem.ToString() != ID)
                {
                    using (StreamWriter reWriteDB = File.AppendText("Users.txt"))
                    {
                        reWriteDB.WriteLine(i);
                    }
                }
                else ID = "";
            }
            MessageBox.Show("Successfully deleted!");
            chooseUserToDelete.SelectedIndex = -1;           
            refreshUsersCombobox();
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm");
        }
    }
}
