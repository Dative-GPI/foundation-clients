using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Foundation.Clients.ViewModels.Admin;

namespace Foundation.Clients.Abstractions.Admin
{
    public interface IAdminRoutineExecutionFoundationClient
    {
        void Init(IFoundationClient root);
        Task<RoutineExecutionDetailsViewModel> Get(Guid routineId, Guid executionId);
        Task<IEnumerable<RoutineExecutionInfosViewModel>> GetMany(Guid routineId, RoutineExecutionFilter filter);
    }
}