using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMSApplication
{
    public class User
    {
        public virtual int ID { set; get; }
        public virtual string User_Name { set; get; }
        public virtual string Password { set; get; }
        public virtual bool Admin { set; get; }
        public User(int id,string username,string password,bool admin)
        {
            this.ID = id;
            this.User_Name = username;
            this.Password = password;
            this.Admin = admin;
        }
        public User()
        { }
        public virtual void setAamin(bool admin)
        {
            this.Admin = admin;
        }
        public virtual bool getAdmin()
        {
            return this.Admin;
        }
        public override string ToString()
        {
            return "User ID: " + this.ID.ToString() + " | Username: " + this.User_Name + " | Admin Priviliges: " + Admin.ToString();
        }
    }
}
