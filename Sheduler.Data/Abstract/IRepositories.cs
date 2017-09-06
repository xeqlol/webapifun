using System;
using System.Collections.Generic;
using System.Text;
using Scheduler.Model;
using Scheduler.Model.Entities;

namespace Scheduler.Data.Abstract
{
    public interface IScheduleRepository : IEntityBaseRepository<Schedule> { }
    public interface IUserRepository : IEntityBaseRepository<User> { }
    public interface IAttendeeRepository : IEntityBaseRepository<Attendee> { }
}
