using HR.LeaveManagment.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Application.Persistence.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
    }
}
