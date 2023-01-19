using BlackCoderLeaveManagementApp.Contracts;
using BlackCoderLeaveManagementApp.Data;

namespace BlackCoderLeaveManagementApp.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
