using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Foundation.Clients.ViewModels.Dispatcher;

namespace Foundation.Clients.Abstractions.Dispatcher
{
    public interface IDispatcherRoutineFoundationClient
    {
        void Init(IFoundationClient root);
        Task<RoutineExecutionDetailsViewModel> Send(Guid routineId, SendRoutineViewModel payload);
    }
}