using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCMSApplication
{
    class LeaveBalance
    {
        protected int ID;
        protected int EmployeeID;
        private int MaternalLeave;
        private int AnnualPaidLeave;
        private int AnnualUnpaidLeave;
        private int SickLeave;
        private int HolidayLeave;

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

        public int GetID()
        {
            return this.ID;
        }
        public int GetEmployeeID()
        {
            return this.EmployeeID;
        }
        public int getMaternalLeave()
        {
            return this.MaternalLeave;
        }
        public void setMaternalLeave(int leave)
        {
            this.MaternalLeave = leave;
        }
        public int getAnnualPaidLeave()
        {
            return this.AnnualPaidLeave;
        }
        public void setAnnualPaidLeave(int leave)
        {
            this.AnnualPaidLeave = leave;
        }
        public int getAnnualUnpaidLeave()
        {
            return this.AnnualUnpaidLeave;
        }
        public void setAnnualUnpaidLeave(int leave)
        {
            this.AnnualUnpaidLeave = leave;
        }
        public int getSickLeave()
        {
            return this.SickLeave;
        }
        public void setSickLeave(int leave)
        {
            this.SickLeave = leave;
        }
        public int getHolidayLeave()
        {
            return this.HolidayLeave;
        }
        public void setHolidayLeave(int leave)
        {
            this.HolidayLeave = leave;
        }
    }
}
