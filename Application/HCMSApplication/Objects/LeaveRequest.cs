using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMSApplication
{
    public class LeaveRequest
    {
        protected int ID;
        protected int EmployeeID;
        private DateTime Start;
        private DateTime End;
        protected string ApproovalStatus;
        private string LeaveType;
        public LeaveRequest(int id,int employeeID,DateTime startDate,DateTime endDate,string approovalSatus, string leaveType)
        {
            this.ID = id;
            this.EmployeeID = employeeID;
            this.Start = startDate;
            this.End = endDate;
            this.ApproovalStatus = approovalSatus;
            this.LeaveType = leaveType;
        }
        public int GetID()
        {
            return this.ID;
        }
        public int GetEmployeeID()
        {
            return this.EmployeeID;
        }
        public DateTime getStart()
        {
            return this.Start;
        }
        public void setStart(DateTime startDate)
        {
            this.Start = startDate;
        }
        public DateTime getEnd()
        {
            return this.End;
        }
        public void setEnd(DateTime endDate)
        {
            this.End = endDate;
        }
        public string getLeaveType()
        {
            return this.LeaveType;
        }
        public void setLeaveType(string leaveType)
        {
            this.LeaveType = leaveType;
        }
    }
}
