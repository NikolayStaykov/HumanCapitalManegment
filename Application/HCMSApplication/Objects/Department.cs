using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMSApplication
{
    public class Department
    {
        public virtual int ID { set; get; }
        public virtual string DepartmentName { set; get; }

        public Department(int id,string name)
        {
            this.DepartmentName = name;
            this.ID = id;
        }
        public Department()
        { }

        public override string ToString()
        {
            return "Department Name: " + this.DepartmentName;
        }
    }
}
