using HR.LeaveManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Domain
{
    public class LeaveAllocation : BaseDomainEntity
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveType LeaveType { get; set; }
        public int Period { get; set; }
    }
}
