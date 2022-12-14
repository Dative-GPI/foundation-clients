using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Dispatcher
{
    public enum RoutineExecutionStatus
    {
        Unknown = 0,
        Created = 1,
        Sent = 2,
        Delivered = 3,
        SendingFailed = 4,
        Expired = 5,
        DeliveryCountExceeded = 6,
        Rejected = 7,
        Purged = 8
    };
}