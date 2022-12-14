using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Foundation.Clients.ViewModels.Admin;

namespace Foundation.Clients.Abstractions.Admin
{
    public interface IAdminRoutineFoundationClient
    {
        void Init(IFoundationClient root);
        Task<RoutineDetailsViewModel> Get(Guid routineId);
        Task<IEnumerable<RoutineInfosViewModel>> GetMany(RoutineFilter filter);
    }
}