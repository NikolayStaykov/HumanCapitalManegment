using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMSApplication
{
    class Employee
    {
        protected int ID;
        private string Name;
        private string Address;
        private string Email;
        private string Phone;
        private string EmergencyContact;
        private string EmploymentStatus;
        private int Salary;
        private int Position_ID;

        public Employee(int iD, string name, string address, string email, string phone, string emergencyContact, string employmentStatus, int salary, int position_ID)
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
        
        public int getID()
        {
            return this.ID;
        }
        public void setName(string name)
        {
            this.Name = name;
        }
        public string getName()
        {
            return this.Name;
        }
        public void setAddress(string address)
        {
            this.Address = address;
        }
        public string getAddress()
        {
            return this.Address;
        }
        public void setEmail(string email)
        {
            this.Email = email;
        }
        public string getEmail()
        {
            return this.Email;
        }
        public void setPhone(string phone)
        {
            this.Phone = phone;
        }
        public string getPhone()
        {
            return this.Phone;
        }
        public void setEmergencyContact(string emergencyContact)
        {
            this.EmergencyContact = emergencyContact;
        }
        public string getEmergencyContact()
        {
            return this.EmergencyContact;
        }
        public void setEmploymentStatus(string employmentStatus)
        {
            this.EmploymentStatus = employmentStatus;
        }
        public string getEmploymentStatus()
        {
            return this.EmploymentStatus;
        }
        public int getSalary()
        {
            return this.Salary;
        }
        public void setSalary(int salary)
        {
            this.Salary = salary;
        }
        public int getPosition_ID()
        {
            return this.Position_ID;
        }
        public void setPosition_ID(int position_ID)
        {
            this.Position_ID = position_ID;
        }
    }
}
