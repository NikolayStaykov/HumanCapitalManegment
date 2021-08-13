using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMSApplication
{
    public class Position
    {
        public virtual int ID { set; get; }
        public virtual int DepartmentID { set; get; }
        public virtual string Name { set; get; }
        public virtual string Description { set; get; }
        public Position(int id,int departmentID,string name,string description)
        {
            this.ID = id;
            this.DepartmentID = departmentID;
            this.Name = name;
            this.Description = description;
        }
        public Position()
        { }
        public override string ToString()
        {
            return "Position ID: " + this.ID + " | Name: " + this.Name + " | Description: " + this.Description;
        }
    }
}
