using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMSApplication
{
    class Position
    {
        protected int ID;
        protected int DepartmentID;
        private string Name;
        private string Description;
        public Position(int id,int departmentID,string name,string description)
        {
            this.ID = id;
            this.DepartmentID = departmentID;
            this.Name = name;
            this.Description = description;
        }
        public int getID()
        {
            return this.ID;
        }
        public int getDepartmentID()
        {
            return this.DepartmentID;
        }
        public void setName(string name)
        {
            this.Name = name;
        }
        public string getName()
        {
            return this.Name;
        }
        public void setDescription(string description)
        {
            this.Description = description;
        }
        public string getDescription()
        {
            return this.Description;
        }
    }
}
