﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler.Model.Entities
{
    public enum ScheduleType
    {
        Work = 1,
        Coffee = 2,
        Doctor = 3,
        Schopping = 4,
        Other = 5
    }

    public enum ScheduleStatus
    {
        Valid = 1,
        Cancelled = 2
    }
}
