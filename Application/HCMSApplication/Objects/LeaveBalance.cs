using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMSApplication
{
    public class LeaveBalance
    {
        public virtual int ID { set; get; }
        public virtual int EmployeeID { set; get; }
        public virtual int MaternalLeave { set; get; }
        public virtual int AnnualPaidLeave { set; get; }
        public virtual int AnnualUnpaidLeave { set; get; }
        public virtual int SickLeave { set; get; }
        public virtual int HolidayLeave { set; get; }

        public LeaveBalance(int id, int employeeID, int maternal, int annualPaid, int annualUnpaid, int sickLeave, int holiday)
        {
            this.ID = id;
            this.EmployeeID = employeeID;
            this.MaternalLeave = maternal;
            this.AnnualPaidLeave = annualPaid;
            this.AnnualUnpaidLeave = annualUnpaid;
            this.SickLeave = sickLeave;
            this.HolidayLeave = holiday;
        }
        public LeaveBalance() { }
    }
}
