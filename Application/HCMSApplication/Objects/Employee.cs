using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMSApplication
{
    public class Employee
    {
        public virtual int ID { set; get; }
        public virtual string Name { set; get; }
        public virtual string Address { set; get; }
        public virtual string Email { set; get; }
        public virtual string Phone { set; get; }
        public virtual string EmergencyContact { set; get; }
        public virtual string EmploymentStatus { set; get; }
        public virtual string Salary { set; get; }
        public virtual int Position_ID { set; get; }

        public Employee(int iD, string name, string address, string email, string phone, string emergencyContact, string employmentStatus, string salary, int position_ID)
        {
            ID = iD;
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
            EmergencyContact = emergencyContact;
            EmploymentStatus = employmentStatus;
            Salary = salary;
            Position_ID = position_ID;
        }
        
        public Employee()
        { }
        public override string ToString()
        {
            return "Employee ID: " + this.ID.ToString() + " |Name: " + this.Name + " |Address: " + this.Address + " |Email: " + this.Email + " |Phone:" + this.Phone + "|Salary:" + this.Salary.ToString() + " |Employment Status: " + this.EmploymentStatus;
        }
    }
}
