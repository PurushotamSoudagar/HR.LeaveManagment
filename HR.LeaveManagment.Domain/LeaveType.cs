using HR.LeaveManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Domain
{
    public class LeaveType: BaseDomainEntity
    {
     
        public string Name { get; set; }
        public int DefaultDays { get; set; }
       

    }
}
