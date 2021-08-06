using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMSApplication
{
    public class Department
    {
        protected int ID;
        private string DepartmentName;

        public Department(int id,string name)
        {
            this.DepartmentName = name;
            this.ID = id;
        }

        public void SetDepartmentName(string name)
        {
            this.DepartmentName = name;
        }
        public string GetDepartmentName()
        {
            return this.DepartmentName;
        }
        public int getID()
        {
            return this.ID;
        }
    }
}
