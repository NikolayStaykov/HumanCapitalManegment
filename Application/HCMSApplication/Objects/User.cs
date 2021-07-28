using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMSApplication
{
    class User
    {
        protected int ID;
        private string Username;
        private string Password;
        private bool Admin;
        public User(int id,string username,string password,bool admin)
        {
            this.ID = id;
            this.Username = username;
            this.Password = password;
            this.Admin = admin;
        }
        public int getID()
        {
            return this.ID;
        }
        public string getUsername()
        {
            return this.Username;
        }
        public string getPassword()
        {
            return this.Password;
        }
        public void setPassword(string password)
        {
            this.Password = password;
        }
        public bool getAdmin()
        {
            return this.Admin;
        }
        public void setAdmin(bool admin)
        {
            this.Admin = admin;
        }
    }
}
