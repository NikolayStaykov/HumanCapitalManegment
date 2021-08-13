using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMSApplication
{
    public class LeaveRequest
    {
        public virtual int ID { set; get; }
        public virtual int EmployeeID { set; get; }
        public virtual DateTime Start { set; get; }
        public virtual DateTime End { set; get; }
        public virtual string ApproovalStatus { set; get; }
        public virtual string LeaveType { set; get; }
        public LeaveRequest(int id,int employeeID,DateTime startDate,DateTime endDate,string approovalSatus, string leaveType)
        {
            this.ID = id;
            this.EmployeeID = employeeID;
            this.Start = startDate;
            this.End = endDate;
            this.ApproovalStatus = approovalSatus;
            this.LeaveType = leaveType;
        }
        public LeaveRequest() { }
        public override string ToString()
        {
            return "Request ID: " + this.ID.ToString() + " | Employee ID: " + this.EmployeeID.ToString() + " | Start: " + this.Start.ToShortDateString() + " | End: " + this.End.ToShortDateString() + " | Status: " + this.ApproovalStatus + " | Leave Type: " + this.LeaveType;
        }
    }
}
