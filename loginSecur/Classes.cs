using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginSecur
{
    class USBDrive
    {
        public string name { get; set; }
        public string volumeLabel { get; set; }  
        public string totalSize { get; set; }       
        public USBDrive(string name, string volumeLabel, string totalSize)
        {
            this.name = name;
            this.volumeLabel = volumeLabel;
            this.totalSize = totalSize;
        }
    }    

    class USBDataBase : USBDrive
    {
        public int hashCodeOfTheUSB { get; set; }
        public USBDataBase(string name, string volumeLabel, string totalSize, int hashCodeOfTheUSB) : base(name, volumeLabel, totalSize)
        {
            this.name = name;
            this.volumeLabel = volumeLabel;
            this.totalSize = totalSize;
            this.hashCodeOfTheUSB = hashCodeOfTheUSB;
        }
    }   

    class User
    {
        public string ID { get; set; }
        public string Password { get; set; }
        public User(string ID, string Password)
        {
            this.ID = ID;
            this.Password = Password;
        }
    }
  
}
